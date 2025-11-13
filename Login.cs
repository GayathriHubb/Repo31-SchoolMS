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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SchoolMS\School.mdf;Integrated Security=True";

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtBxUsername.Text == string.Empty || TxtBxPswrd.Text == string.Empty)
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
                        string seldata = "Select Count(*) From Users Where UserName = @un AND Password = @pswd";

                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            selcmd.Parameters.AddWithValue("@pswd", TxtBxPswrd.Text.Trim());

                            int rowcount = 0;
                            object result = selcmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rowcount = Convert.ToInt32(result);
                            }

                            if (rowcount > 0)
                            {
                                MessageBox.Show("Login Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                SchoolData.Username = TxtBxUsername.Text;

                                FormHome home = new FormHome();
                                home.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Login - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Clear();
            TxtBxPswrd.Clear();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            Hide();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }

        private void LbFrgtPswrd_Click(object sender, EventArgs e)
        {
            FormFrgtPswrd frgtpswrd = new FormFrgtPswrd();
            frgtpswrd.ShowDialog();
            Hide();
        }
    }
}
