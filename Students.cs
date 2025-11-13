using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SchoolMS
{
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SchoolMS\School.mdf;Integrated Security=True";

        string targetpath;
        private void FormStudents_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayStudentsData();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void FormStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            Hide();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Please Fill in All Fields and Select a Photo", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string stdid = TxtBxStdId.Text.Trim().ToUpper();
                try
                {
                    string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativepath = Path.Combine("StudentsDirectory", $"{stdid}.jpg");
                    targetpath = Path.Combine(basedirectory, relativepath);

                    string directorypath = Path.GetDirectoryName(targetpath);
                    if (!Directory.Exists(directorypath))
                    {
                        Directory.CreateDirectory(directorypath);
                    }

                    if (!string.IsNullOrEmpty(PicBxStd.ImageLocation))
                    {
                        File.Copy(PicBxStd.ImageLocation, targetpath, true);
                    }
                    MessageBox.Show("Image Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Image - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkstdid = "Select Count(*) From Students Where StudentId = @stdid AND DateDelete IS NULL";
                        using (SqlCommand chkcmd = new SqlCommand(chkstdid, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@stdid", stdid);
                            int rowcount = 0;
                            object result = chkcmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rowcount = Convert.ToInt32(result);
                            }
                            if (rowcount > 0)
                            {
                                MessageBox.Show($"StudentId: {stdid} Already Exists. Please Use a Different StudentId", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        string insdata = "Insert Into Students (StudentId, StudentName, Gender, Address, Class, Section, Status, ImagePath, DateInsert) " +
                                          "Values (@stdid, @stdname, @gender, @addrss, @class, @section, @status, @imgpath, @dtins)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@stdid", stdid);
                            inscmd.Parameters.AddWithValue("@stdname", TxtBxName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@gender", CmbBxGender.Text.Trim());
                            inscmd.Parameters.AddWithValue("@addrss", TxtBxAddress.Text.Trim());
                            inscmd.Parameters.AddWithValue("@class", CmbBxClass.Text.Trim());
                            inscmd.Parameters.AddWithValue("@section", CmbBxSection.Text.Trim());
                            inscmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim()); 
                            inscmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                            inscmd.ExecuteNonQuery();
                            DisplayStudentsData();
                            MessageBox.Show("Student Record Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Insert - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
            }
                
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Please Fill in All Fields and Select a Photo", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string stdid = TxtBxStdId.Text.Trim().ToUpper();

                DialogResult dr = MessageBox.Show($"Are you sure you want to Update the StudentId: {stdid}?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string relativepath = Path.Combine("StudentsDirectory", $"{stdid}.jpg");
                        targetpath = Path.Combine(basedirectory, relativepath);

                        if (!string.IsNullOrEmpty(PicBxStd.ImageLocation))
                        {
                            File.Copy(PicBxStd.ImageLocation, targetpath, true);
                        }

                        MessageBox.Show("Image Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Image - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string updata = "Update Students Set StudentName = @stdname, Gender = @gender, Address = @addrss, Class = @class, Section = @section, Status = @status, ImagePath = @imgpath, DateUpdate = @dtupd " +
                                            "Where StudentId = @stdid AND Id = @id";

                            using (SqlCommand updcmd = new SqlCommand(updata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@stdname", TxtBxName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@gender", CmbBxGender.Text.Trim());
                                updcmd.Parameters.AddWithValue("@addrss", TxtBxAddress.Text.Trim());
                                updcmd.Parameters.AddWithValue("@class", CmbBxClass.Text.Trim());
                                updcmd.Parameters.AddWithValue("@section", CmbBxSection.Text.Trim());
                                updcmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                                updcmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                                updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);
                                updcmd.Parameters.AddWithValue("@stdid", stdid);
                                updcmd.Parameters.AddWithValue("@id", getid);

                                updcmd.ExecuteNonQuery();

                                DisplayStudentsData();
                                MessageBox.Show("Student Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Update - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
                    

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxStdId.Text) || getid == 0)
            {
                MessageBox.Show("Please Enter the StudentId to Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string stdid = TxtBxStdId.Text.Trim().ToUpper();

                DialogResult dr = MessageBox.Show($"Are you sure you want to Delete the StudentId: {stdid}?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Update Students Set DateDelete = @dtdel Where StudentId = @stdid AND Id = @id";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@stdid", stdid);
                                delcmd.Parameters.AddWithValue("@id", getid);
                                delcmd.Parameters.AddWithValue("@dtdel", DateTime.Today);

                                delcmd.ExecuteNonQuery();
                                MessageBox.Show("Student Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "SQL Delete - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnStdPic_Click(object sender, EventArgs e)
        {
            try
            {
                string imgpath = string.Empty;

                if (Ofd.ShowDialog() == DialogResult.OK)
                {
                    imgpath = Ofd.FileName;
                    PicBxStd.ImageLocation = imgpath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PicBx - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        int getid;
        private void DGVStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DGVStudents.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;

                    TxtBxStdId.Text = (string)row.Cells[1].Value;
                    TxtBxName.Text = (string)row.Cells[2].Value;
                    TxtBxAddress.Text = (string)row.Cells[4].Value;
                    CmbBxGender.Text = (string)row.Cells[3].Value;
                    CmbBxClass.Text = (string)row.Cells[5].Value;
                    CmbBxSection.Text = (string)row.Cells[6].Value;
                    CmbBxStatus.Text = (string)(row.Cells[7].Value);

                    string imgpath = (string)row.Cells[8].Value;

                    if (File.Exists(imgpath))
                    {
                        PicBxStd.ImageLocation = imgpath;
                    }
                    PicBxStd.Image = null;
                }
            } 
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "DGV - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void ClearFields()
        {
            TxtBxStdId.Clear();
            TxtBxName.Clear();  
            TxtBxAddress.Clear();
            CmbBxGender.SelectedIndex = -1;
            CmbBxClass.SelectedIndex = -1;
            CmbBxSection.SelectedIndex = -1;
            CmbBxStatus.SelectedIndex = -1;
            PicBxStd.Image = null;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(TxtBxStdId.Text) || string.IsNullOrWhiteSpace(TxtBxName.Text) || string.IsNullOrWhiteSpace(TxtBxAddress.Text) ||
                CmbBxGender.SelectedIndex == -1 || CmbBxClass.SelectedIndex == -1 || CmbBxSection.SelectedIndex == -1 || CmbBxStatus.SelectedIndex == -1 || PicBxStd.Image == null)
            {
                return true;
            }
            return false;
        }

        private void DisplayStudentsData()
        {
            StudentsData sd = new StudentsData();
            DGVStudents.DataSource = sd.ListStudents();

            if (MaximizeBox == true)
            {
                DGVStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                DGVStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
        }
    }
}
