using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            string un = SchoolData.Username;
            LbUser.Text = $"{un.Substring(0, 1).ToUpper()}{un.Substring(1)}";
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Exit ?", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else { Application.ExitThread(); }
        }

        private void PicBxLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Logout ?", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FormLogin loginform = new FormLogin();
                loginform.Show();
                Hide();
            }
        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FormDashBoard dshbrd = new FormDashBoard();
            dshbrd.Show();
            Hide();
        }

        private void BtnTeachers_Click(object sender, EventArgs e)
        {
            FormTeachers tchrs = new FormTeachers();
            tchrs.Show();
            Hide();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            FormStudents stdnts = new FormStudents();
            stdnts.Show();
            Hide();
        }

        private void PicBxLogout_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(PicBxLogout, "Logout");
        }
    }
}
