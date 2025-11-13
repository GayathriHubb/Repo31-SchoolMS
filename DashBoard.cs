using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SchoolMS\School.mdf;Integrated Security=True";
        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayTotTeachers();
                    DisplayEnrolledStds();
                    DisplayGraduatedStds();
                    DisplayEnrStdsTod();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void FormDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            Hide();
        }

        public void DisplayTotTeachers()
        { 
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select COUNT(TeacherId) From Teachers Where DateDelete is NULL";
                    using (SqlCommand sqlcmd = new SqlCommand(seldata, sqlcon))
                    {
                        int tottchs = (int)sqlcmd.ExecuteScalar();
                        LbTotTchs.Text = tottchs.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DisplayTotTeachers - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void DisplayEnrolledStds()
        { 
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select COUNT(StudentId) From Students Where Status = @status AND DateDelete is NULL";
                    using (SqlCommand sqlcmd = new SqlCommand(seldata, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@status", "Enrolled");
                        int enrolstds = (int)sqlcmd.ExecuteScalar();
                        LbEnrStds.Text = enrolstds.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DispEnrolledStds - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void DisplayGraduatedStds()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select COUNT(StudentId) From Students Where Status = @status AND DateDelete is NULL";
                    using (SqlCommand sqlcmd = new SqlCommand(seldata, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@status", "Graduated");
                        int grdstds = (int)sqlcmd.ExecuteScalar();
                        LbGrdStds.Text = grdstds.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DispGraduatedStds - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void DisplayEnrStdsTod()
        {
            StudentsData stdsdata = new StudentsData();
            DGVDashBoard.DataSource = stdsdata.ListEnrStdsTod();

            if (MaximizeBox == true)
            {
                DGVDashBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                DGVDashBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
        }

           
    }
}
