using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS
{
    public partial class FormFrgtPswrd : Form
    {
        public FormFrgtPswrd()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SchoolMS\School.mdf;Integrated Security=True";

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            SchoolData.Username = TxtBxUsername.Text.Trim();
            if (TxtBxUsername.Text == string.Empty || CmbBxSecQsns.Text == string.Empty || TxtBxUsername.Text == string.Empty)
            {
                MessageBox.Show("All Fields Are Required To be Filled", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select Count(*) From Users Where Username = @un AND (Question = @qsn AND Answer = @ans)";

                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            selcmd.Parameters.AddWithValue("@qsn", CmbBxSecQsns.Text.Trim());
                            selcmd.Parameters.AddWithValue("@ans", TxtBxSecAns.Text.Trim());

                            int rowcount = 0;
                            object result = selcmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            { rowcount = Convert.ToInt32(result); }

                            if (rowcount > 0)
                            {
                                FormChangePswrd chngpswrd = new FormChangePswrd();
                                chngpswrd.ShowDialog();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Information", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Confirm - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            Hide(); 
        }
    }
}
