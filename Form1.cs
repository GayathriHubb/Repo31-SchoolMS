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
    public partial class Form1Load : Form
    {
        public Form1Load()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Pnl2.Width += 5;

            if (Pnl2.Width >= Pnl1.Width) 
            { 
                Timer1.Stop();
                FormLogin login = new FormLogin();
                login.Show();
                Hide();
            }
        }
    }
}
