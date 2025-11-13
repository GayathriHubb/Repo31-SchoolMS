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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SchoolMS\School.mdf;Integrated Security=True";

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Clear();
            TxtBxPswrd.Clear();
            TxtBxCnfrmPswrd.Clear();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtBxUsername.Text == string.Empty || TxtBxPswrd.Text == string.Empty || TxtBxCnfrmPswrd.Text == string.Empty || CmbBxSecQsns.SelectedIndex == -1 || TxtBxSecAns.Text == string.Empty)
            {
                MessageBox.Show("All Fields Are Required To Be Filled", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string username = TxtBxUsername.Text.Trim();
                string password = TxtBxPswrd.Text.Trim();
                string confirmpassword = TxtBxCnfrmPswrd.Text.Trim();
                string securityquestion = CmbBxSecQsns.Text.Trim();
                string securityanswer = TxtBxSecAns.Text.Trim();

                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string checkun = "Select Count(*) From Users Where UserName = @un";

                        using (SqlCommand uncmd = new SqlCommand(checkun, sqlcon))
                        {
                            uncmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            int rowcount = 0;
                            object result = uncmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rowcount = Convert.ToInt32(result);
                            }

                            if (rowcount > 0)
                            {
                                string tempun = $"{TxtBxUsername.Text.Substring(0, 1).ToUpper()}{TxtBxUsername.Text.Substring(1)}";
                                MessageBox.Show($"Username: {tempun} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                            else if (password.Length < 8)
                            {
                                MessageBox.Show("Invalid Password.. Password Must be 8 characters or up", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else if (password != confirmpassword)
                            {
                                MessageBox.Show("Passwords Does Not Match", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insdata = "Insert Into Users (UserName, Password, Question, Answer, DateRegister) Values (@un, @pswd, @qsn, @ans, @dtcrtd)";

                                using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@un", username);
                                    inscmd.Parameters.AddWithValue("@pswd", password);
                                    inscmd.Parameters.AddWithValue("@qsn", securityquestion);
                                    inscmd.Parameters.AddWithValue("@ans", securityanswer);
                                    inscmd.Parameters.AddWithValue("@dtcrtd", DateTime.Today);

                                    inscmd.ExecuteNonQuery();

                                    MessageBox.Show("Registration Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                    FormLogin login = new FormLogin();
                                    login.Show();
                                    Hide();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SignUp - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
            TxtBxCnfrmPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            Hide();
        }

    }
}
