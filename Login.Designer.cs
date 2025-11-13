namespace SchoolMS
{
    partial class FormLogin
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
            this.LbLogin = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.LbFrgtPswrd = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.LbNoAcc = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.PicBxUser = new System.Windows.Forms.PictureBox();
            this.PnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbLogin.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogin.ForeColor = System.Drawing.Color.Wheat;
            this.LbLogin.Location = new System.Drawing.Point(684, 120);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(121, 34);
            this.LbLogin.TabIndex = 1;
            this.LbLogin.Text = "SIGN IN";
            this.LbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Wheat;
            this.LbHeading.Location = new System.Drawing.Point(64, 55);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(436, 43);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "PRAGATHI E.M. SCHOOL";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.Wheat;
            this.PnlLogin.Controls.Add(this.LbFrgtPswrd);
            this.PnlLogin.Controls.Add(this.BtnRegister);
            this.PnlLogin.Controls.Add(this.LbNoAcc);
            this.PnlLogin.Controls.Add(this.BtnClear);
            this.PnlLogin.Controls.Add(this.BtnLogin);
            this.PnlLogin.Controls.Add(this.ChkBxPswrd);
            this.PnlLogin.Controls.Add(this.LbPassword);
            this.PnlLogin.Controls.Add(this.LbUsername);
            this.PnlLogin.Controls.Add(this.TxtBxUsername);
            this.PnlLogin.Controls.Add(this.TxtBxPswrd);
            this.PnlLogin.Location = new System.Drawing.Point(64, 176);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(750, 430);
            this.PnlLogin.TabIndex = 3;
            // 
            // LbFrgtPswrd
            // 
            this.LbFrgtPswrd.AutoSize = true;
            this.LbFrgtPswrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbFrgtPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFrgtPswrd.ForeColor = System.Drawing.Color.Navy;
            this.LbFrgtPswrd.Location = new System.Drawing.Point(412, 163);
            this.LbFrgtPswrd.Name = "LbFrgtPswrd";
            this.LbFrgtPswrd.Size = new System.Drawing.Size(164, 25);
            this.LbFrgtPswrd.TabIndex = 4;
            this.LbFrgtPswrd.Text = "Forgot Password ?";
            this.LbFrgtPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbFrgtPswrd.Click += new System.EventHandler(this.LbFrgtPswrd_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegister.AutoSize = true;
            this.BtnRegister.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegister.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnRegister.Location = new System.Drawing.Point(232, 345);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(300, 50);
            this.BtnRegister.TabIndex = 12;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LbNoAcc
            // 
            this.LbNoAcc.AutoSize = true;
            this.LbNoAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.LbNoAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNoAcc.Location = new System.Drawing.Point(282, 300);
            this.LbNoAcc.Name = "LbNoAcc";
            this.LbNoAcc.Size = new System.Drawing.Size(201, 32);
            this.LbNoAcc.TabIndex = 11;
            this.LbNoAcc.Text = "No Account Yet ?";
            this.LbNoAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnClear.Location = new System.Drawing.Point(376, 211);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(200, 45);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnLogin.Location = new System.Drawing.Point(145, 211);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(200, 45);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.Location = new System.Drawing.Point(389, 126);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(192, 34);
            this.ChkBxPswrd.TabIndex = 7;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = true;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(141, 87);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(118, 28);
            this.LbPassword.TabIndex = 8;
            this.LbPassword.Text = "Password";
            this.LbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.Location = new System.Drawing.Point(140, 33);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(124, 28);
            this.LbUsername.TabIndex = 5;
            this.LbUsername.Text = "Username";
            this.LbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(281, 29);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 37);
            this.TxtBxUsername.TabIndex = 4;
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(281, 83);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxPswrd.TabIndex = 6;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // PicBxUser
            // 
            this.PicBxUser.Image = global::SchoolMS.Properties.Resources.User;
            this.PicBxUser.Location = new System.Drawing.Point(697, 20);
            this.PicBxUser.Name = "PicBxUser";
            this.PicBxUser.Size = new System.Drawing.Size(90, 90);
            this.PicBxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxUser.TabIndex = 0;
            this.PicBxUser.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.LbLogin);
            this.Controls.Add(this.PicBxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxUser;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label LbNoAcc;
        private System.Windows.Forms.Label LbFrgtPswrd;
    }
}