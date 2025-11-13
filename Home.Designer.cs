namespace SchoolMS
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.BtnStudents = new System.Windows.Forms.Button();
            this.BtnTeachers = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.LbUser = new System.Windows.Forms.Label();
            this.LbWelcome = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.PicBxLogout = new System.Windows.Forms.PictureBox();
            this.PicBxStudents = new System.Windows.Forms.PictureBox();
            this.PicBxTeachers = new System.Windows.Forms.PictureBox();
            this.PicBxDashBoard = new System.Windows.Forms.PictureBox();
            this.PicBxHome = new System.Windows.Forms.PictureBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxDashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStudents
            // 
            this.BtnStudents.AutoSize = true;
            this.BtnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudents.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudents.ForeColor = System.Drawing.Color.Snow;
            this.BtnStudents.Location = new System.Drawing.Point(619, 530);
            this.BtnStudents.Name = "BtnStudents";
            this.BtnStudents.Size = new System.Drawing.Size(150, 50);
            this.BtnStudents.TabIndex = 11;
            this.BtnStudents.Text = "STUDENTS ";
            this.BtnStudents.UseVisualStyleBackColor = false;
            this.BtnStudents.Click += new System.EventHandler(this.BtnStudents_Click);
            // 
            // BtnTeachers
            // 
            this.BtnTeachers.AutoSize = true;
            this.BtnTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTeachers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeachers.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeachers.ForeColor = System.Drawing.Color.Snow;
            this.BtnTeachers.Location = new System.Drawing.Point(352, 530);
            this.BtnTeachers.Name = "BtnTeachers";
            this.BtnTeachers.Size = new System.Drawing.Size(150, 50);
            this.BtnTeachers.TabIndex = 10;
            this.BtnTeachers.Text = "TEACHERS";
            this.BtnTeachers.UseVisualStyleBackColor = false;
            this.BtnTeachers.Click += new System.EventHandler(this.BtnTeachers_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.AutoSize = true;
            this.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.Snow;
            this.BtnDashboard.Location = new System.Drawing.Point(90, 530);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(153, 50);
            this.BtnDashboard.TabIndex = 9;
            this.BtnDashboard.Text = "DASHBOARD";
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // LbUser
            // 
            this.LbUser.AutoSize = true;
            this.LbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbUser.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbUser.Location = new System.Drawing.Point(420, 270);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(29, 29);
            this.LbUser.TabIndex = 13;
            this.LbUser.Text = " -";
            this.LbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbWelcome
            // 
            this.LbWelcome.AutoSize = true;
            this.LbWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbWelcome.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWelcome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbWelcome.Location = new System.Drawing.Point(287, 270);
            this.LbWelcome.Name = "LbWelcome";
            this.LbWelcome.Size = new System.Drawing.Size(134, 29);
            this.LbWelcome.TabIndex = 12;
            this.LbWelcome.Text = "Welcome, ";
            this.LbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbHeading.Location = new System.Drawing.Point(238, 30);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(392, 38);
            this.LbHeading.TabIndex = 14;
            this.LbHeading.Text = "PRAGATHI E.M. SCHOOL";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBxLogout
            // 
            this.PicBxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBxLogout.Image = global::SchoolMS.Properties.Resources.LogoutSkeuomorphism;
            this.PicBxLogout.Location = new System.Drawing.Point(750, 100);
            this.PicBxLogout.Name = "PicBxLogout";
            this.PicBxLogout.Size = new System.Drawing.Size(80, 80);
            this.PicBxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxLogout.TabIndex = 8;
            this.PicBxLogout.TabStop = false;
            this.PicBxLogout.Click += new System.EventHandler(this.PicBxLogout_Click);
            this.PicBxLogout.MouseHover += new System.EventHandler(this.PicBxLogout_MouseHover);
            // 
            // PicBxStudents
            // 
            this.PicBxStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBxStudents.Image = global::SchoolMS.Properties.Resources.Boy;
            this.PicBxStudents.Location = new System.Drawing.Point(619, 370);
            this.PicBxStudents.Name = "PicBxStudents";
            this.PicBxStudents.Size = new System.Drawing.Size(150, 150);
            this.PicBxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxStudents.TabIndex = 7;
            this.PicBxStudents.TabStop = false;
            // 
            // PicBxTeachers
            // 
            this.PicBxTeachers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBxTeachers.Image = global::SchoolMS.Properties.Resources.TeacherDesk;
            this.PicBxTeachers.Location = new System.Drawing.Point(352, 370);
            this.PicBxTeachers.Name = "PicBxTeachers";
            this.PicBxTeachers.Size = new System.Drawing.Size(150, 150);
            this.PicBxTeachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxTeachers.TabIndex = 6;
            this.PicBxTeachers.TabStop = false;
            // 
            // PicBxDashBoard
            // 
            this.PicBxDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBxDashBoard.Image = global::SchoolMS.Properties.Resources.Dashboard2;
            this.PicBxDashBoard.Location = new System.Drawing.Point(90, 370);
            this.PicBxDashBoard.Name = "PicBxDashBoard";
            this.PicBxDashBoard.Size = new System.Drawing.Size(150, 150);
            this.PicBxDashBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxDashBoard.TabIndex = 5;
            this.PicBxDashBoard.TabStop = false;
            // 
            // PicBxHome
            // 
            this.PicBxHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBxHome.Image = global::SchoolMS.Properties.Resources.Home1;
            this.PicBxHome.Location = new System.Drawing.Point(352, 100);
            this.PicBxHome.Name = "PicBxHome";
            this.PicBxHome.Size = new System.Drawing.Size(150, 150);
            this.PicBxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxHome.TabIndex = 4;
            this.PicBxHome.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.LbUser);
            this.Controls.Add(this.LbWelcome);
            this.Controls.Add(this.BtnStudents);
            this.Controls.Add(this.BtnTeachers);
            this.Controls.Add(this.BtnDashboard);
            this.Controls.Add(this.PicBxLogout);
            this.Controls.Add(this.PicBxStudents);
            this.Controls.Add(this.PicBxTeachers);
            this.Controls.Add(this.PicBxDashBoard);
            this.Controls.Add(this.PicBxHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxDashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxStudents;
        private System.Windows.Forms.PictureBox PicBxTeachers;
        private System.Windows.Forms.PictureBox PicBxDashBoard;
        private System.Windows.Forms.PictureBox PicBxHome;
        private System.Windows.Forms.PictureBox PicBxLogout;
        private System.Windows.Forms.Button BtnStudents;
        private System.Windows.Forms.Button BtnTeachers;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Label LbUser;
        private System.Windows.Forms.Label LbWelcome;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.ToolTip ToolTip1;
    }
}