using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MethodsFW;

namespace SchoolMS
{
    public partial class FormTeachers : Form
    {
        public FormTeachers()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SchoolMS\School.mdf;Integrated Security=True";

        string targetpath;
        private void FormTeachers_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayTeachersData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void FormTeachers_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            Hide();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields()) 
            {
                MessageBox.Show("Please Fill In All Fields and Select a Photo", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!Solutions.PhnNumInd(TxtBxPhnNum.Text)) 
            {
                MessageBox.Show("Invalid Phone Number.. Pls Enter a Valid Indian Phone NUmber", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidSalary(TxtBxSalary.Text, out int salary)) 
            {
                MessageBox.Show("Invalid Input.. Salary Must be a Non-Negative Integer", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); 
                return;
            }
            else
            {
                string tchid = TxtBxTchId.Text.Trim().ToUpper();
                try
                {
                    string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativepath = Path.Combine("TeachersDirectory", $"{tchid}.jpg");
                    targetpath = Path.Combine(basedirectory, relativepath);

                    string directorypath = Path.GetDirectoryName(targetpath);

                    if (!Directory.Exists(directorypath))
                    {
                        Directory.CreateDirectory(directorypath);
                    }

                    if (!string.IsNullOrEmpty(PicBxTch.ImageLocation))
                    {
                        File.Copy(PicBxTch.ImageLocation, targetpath, true);    
                    }
                    MessageBox.Show("Image Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "PicBx - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string checktchid = "Select Count(*) From Teachers Where TeacherId = @tchid AND DateDelete is NULL";

                        using (SqlCommand checkcmd = new SqlCommand(checktchid, sqlcon))
                        {
                            checkcmd.Parameters.AddWithValue("@tchid", tchid);
                            int rowcount = 0;
                            object result = checkcmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rowcount = Convert.ToInt32(result);
                            }
                            if (rowcount > 0)
                            {
                                MessageBox.Show($"TeacherId: {tchid} Already Exists.. Please Enter a Different TeacherId", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string insdata = "Insert Into Teachers (TeacherId, TeacherName, Gender, Address, PhnNum, Subject, Salary, Status, ImagePath, DateInsert) " +
                            "Values (@tchid, @tchname, @gender, @addrss, @phnnum, @sub, @salary, @status, @imgpath, @dtins)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@tchid", tchid);
                            inscmd.Parameters.AddWithValue("@tchname", TxtBxName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@gender", CmbBxGender.Text.Trim());
                            inscmd.Parameters.AddWithValue("@addrss", TxtBxAddress.Text.Trim());
                            inscmd.Parameters.AddWithValue("@phnnum", TxtBxPhnNum.Text);
                            inscmd.Parameters.AddWithValue("@sub", CmbBxSubject.Text.Trim());
                            inscmd.Parameters.AddWithValue("@salary", salary);
                            inscmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                            inscmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                            inscmd.ExecuteNonQuery();

                            DisplayTeachersData();
                            MessageBox.Show("Teacher Record Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Insert - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Please Fill In All Fields and Select a Photo", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!Solutions.PhnNumInd(TxtBxPhnNum.Text))
            {
                MessageBox.Show("Invalid Phone Number.. Pls Enter a Valid Indian Phone NUmber", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidSalary(TxtBxSalary.Text, out int salary))
            {
                MessageBox.Show("Invalid Input.. Salary Must be a Non-Negative Integer", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string tchid = TxtBxTchId.Text.Trim().ToUpper();
                
                DialogResult dr = MessageBox.Show($"Are you sure you want to Update TeacherId: {tchid} ?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string relativepath = Path.Combine("TeachersDirectory", $"{tchid}.jpg");
                        targetpath = Path.Combine(basedirectory, relativepath);

                        if (!string.IsNullOrEmpty(PicBxTch.ImageLocation))
                        {
                            File.Copy(PicBxTch.ImageLocation, targetpath, true);
                        }

                        MessageBox.Show("Image Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "PicBx- Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        { 
                            sqlcon.Open();

                            string upddata = "Update Teachers Set TeacherName = @tchname, Gender = @gender, Address = @addrss, PhnNum = @phnnum, Subject = @sub, Salary = @salary, Status = @status, ImagePath = @imgpath, DateUpdate = @dtupd Where TeacherId = @tchid";

                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@tchid", tchid);
                                updcmd.Parameters.AddWithValue("@tchname", TxtBxName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@gender", CmbBxGender.Text.Trim());
                                updcmd.Parameters.AddWithValue("@addrss", TxtBxAddress.Text.Trim());
                                updcmd.Parameters.AddWithValue("@phnnum", TxtBxPhnNum.Text);
                                updcmd.Parameters.AddWithValue("@sub", CmbBxSubject.Text.Trim());
                                updcmd.Parameters.AddWithValue("@salary", salary);
                                updcmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                                updcmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                                updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);

                                updcmd.ExecuteNonQuery();

                                DisplayTeachersData();
                                MessageBox.Show("Teacher Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            if (string.IsNullOrWhiteSpace(TxtBxTchId.Text) || getid == 0)
            {
                MessageBox.Show("Please Enter the TeacherId to Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string tchid = TxtBxTchId.Text.Trim().ToUpper();
                DialogResult dr = MessageBox.Show($"Are you Sure you want to Delete TeacherId: {tchid} ?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring)) 
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Update Teachers Set DateDelete = @dtdel Where TeacherId = @tchid";

                            using (SqlCommand delcmd = new SqlCommand(deldata))
                            {
                                delcmd.Parameters.AddWithValue("@tchid", tchid);
                                delcmd.Parameters.AddWithValue("@dtdel", DateTime.Today);

                                delcmd.ExecuteNonQuery();

                                DisplayTeachersData();
                                MessageBox.Show("Teacher Record Deleted Successfully", "Inforamtion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show(ex.Message, "Delete - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        
                    }
                }

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnTchPic_Click(object sender, EventArgs e)
        {
            try
            {
                string imgpath = string.Empty;

                if (Ofd.ShowDialog() == DialogResult.OK)
                {
                    imgpath = Ofd.FileName;
                    PicBxTch.ImageLocation = imgpath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PicBx - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        int getid;
        private void DGVTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DGVTeachers.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;
                    TxtBxTchId.Text = (string)row.Cells[1].Value;
                    TxtBxName.Text = (string) row.Cells[2].Value;
                    TxtBxAddress.Text = (string)row.Cells[4].Value;
                    CmbBxGender.Text = (string) row.Cells[3].Value;
                    TxtBxPhnNum.Text = (string) row.Cells[5].Value;
                    CmbBxSubject.Text = (string) row.Cells[6].Value;
                    TxtBxSalary.Text = Convert.ToInt32(row.Cells[7].Value).ToString();
                    CmbBxStatus.Text = (string)row.Cells [8].Value;

                    string imgpath = (string)row.Cells[9].Value;

                    if (File.Exists(imgpath))
                    {
                        PicBxTch.ImageLocation = imgpath;
                    }
                    PicBxTch.Image = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DGV - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error );    
            }
        }

        private void ClearFields()
        {
            TxtBxTchId.Clear();
            TxtBxName.Clear();
            TxtBxAddress.Clear();
            TxtBxPhnNum.Clear();
            TxtBxSalary.Clear();
            CmbBxGender.SelectedIndex = -1;
            CmbBxSubject.SelectedIndex = -1;
            CmbBxStatus.SelectedIndex = -1;
            PicBxTch.Image = null;
        }
            
        private bool CheckEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(TxtBxTchId.Text) || string.IsNullOrWhiteSpace(TxtBxName.Text) || string.IsNullOrWhiteSpace(TxtBxAddress.Text) || string.IsNullOrWhiteSpace(TxtBxPhnNum.Text) ||
                CmbBxGender.SelectedIndex == -1 || CmbBxSubject.SelectedIndex == -1 || CmbBxStatus.SelectedIndex == -1 || PicBxTch.Image == null)
            {
                return true;
            }
            return false;
        }

        private bool IsValidSalary(string salarytext, out int salary)
        {
            if(int.TryParse(salarytext, out salary))
            {
                if (salary >= 0)
                { return true; }
            }
            return false;
        }

        private void DisplayTeachersData()
        {
            TeachersData td = new TeachersData();
            DGVTeachers.DataSource = td.ListTeachers();

            if (MaximizeBox == true)
            {
                DGVTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                DGVTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
        }
    }
}
