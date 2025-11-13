namespace SchoolMS
{
    partial class FormRegister
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
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.PicBxSchool = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBxSecAns = new System.Windows.Forms.TextBox();
            this.CmbBxSecQsns = new System.Windows.Forms.ComboBox();
            this.LbCnfrmPsrd = new System.Windows.Forms.Label();
            this.TxtBxCnfrmPswrd = new System.Windows.Forms.TextBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.LbNoAcc = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbSignUp = new System.Windows.Forms.Label();
            this.PicBxUser = new System.Windows.Forms.PictureBox();
            this.PnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.Wheat;
            this.PnlLogin.Controls.Add(this.PicBxSchool);
            this.PnlLogin.Controls.Add(this.label5);
            this.PnlLogin.Controls.Add(this.label4);
            this.PnlLogin.Controls.Add(this.TxtBxSecAns);
            this.PnlLogin.Controls.Add(this.CmbBxSecQsns);
            this.PnlLogin.Controls.Add(this.LbCnfrmPsrd);
            this.PnlLogin.Controls.Add(this.TxtBxCnfrmPswrd);
            this.PnlLogin.Controls.Add(this.BtnSignIn);
            this.PnlLogin.Controls.Add(this.LbNoAcc);
            this.PnlLogin.Controls.Add(this.BtnClear);
            this.PnlLogin.Controls.Add(this.BtnSignUp);
            this.PnlLogin.Controls.Add(this.ChkBxPswrd);
            this.PnlLogin.Controls.Add(this.LbPassword);
            this.PnlLogin.Controls.Add(this.LbUsername);
            this.PnlLogin.Controls.Add(this.TxtBxUsername);
            this.PnlLogin.Controls.Add(this.TxtBxPswrd);
            this.PnlLogin.Location = new System.Drawing.Point(29, 160);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(920, 450);
            this.PnlLogin.TabIndex = 7;
            // 
            // PicBxSchool
            // 
            this.PicBxSchool.Image = global::SchoolMS.Properties.Resources.School;
            this.PicBxSchool.Location = new System.Drawing.Point(654, 40);
            this.PicBxSchool.Name = "PicBxSchool";
            this.PicBxSchool.Size = new System.Drawing.Size(150, 150);
            this.PicBxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxSchool.TabIndex = 24;
            this.PicBxSchool.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ans";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Qsn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxSecAns
            // 
            this.TxtBxSecAns.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxSecAns.Location = new System.Drawing.Point(132, 303);
            this.TxtBxSecAns.Name = "TxtBxSecAns";
            this.TxtBxSecAns.Size = new System.Drawing.Size(300, 34);
            this.TxtBxSecAns.TabIndex = 9;
            // 
            // CmbBxSecQsns
            // 
            this.CmbBxSecQsns.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxSecQsns.FormattingEnabled = true;
            this.CmbBxSecQsns.Items.AddRange(new object[] {
            "What is your Favorite Color ?",
            "What is your favorite Place ?",
            "Who is your Favorite Celebrity ?",
            "What is your Nickname ?"});
            this.CmbBxSecQsns.Location = new System.Drawing.Point(132, 240);
            this.CmbBxSecQsns.Name = "CmbBxSecQsns";
            this.CmbBxSecQsns.Size = new System.Drawing.Size(400, 36);
            this.CmbBxSecQsns.TabIndex = 8;
            this.CmbBxSecQsns.Text = "Select Question";
            // 
            // LbCnfrmPsrd
            // 
            this.LbCnfrmPsrd.AutoSize = true;
            this.LbCnfrmPsrd.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnfrmPsrd.Location = new System.Drawing.Point(19, 147);
            this.LbCnfrmPsrd.Name = "LbCnfrmPsrd";
            this.LbCnfrmPsrd.Size = new System.Drawing.Size(198, 26);
            this.LbCnfrmPsrd.TabIndex = 14;
            this.LbCnfrmPsrd.Text = "Confirm Password";
            this.LbCnfrmPsrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxCnfrmPswrd
            // 
            this.TxtBxCnfrmPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCnfrmPswrd.Location = new System.Drawing.Point(232, 139);
            this.TxtBxCnfrmPswrd.Name = "TxtBxCnfrmPswrd";
            this.TxtBxCnfrmPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxCnfrmPswrd.TabIndex = 6;
            this.TxtBxCnfrmPswrd.UseSystemPasswordChar = true;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSignIn.AutoSize = true;
            this.BtnSignIn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSignIn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnSignIn.Location = new System.Drawing.Point(581, 285);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(300, 50);
            this.BtnSignIn.TabIndex = 3;
            this.BtnSignIn.Text = "SIGN IN";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // LbNoAcc
            // 
            this.LbNoAcc.AutoSize = true;
            this.LbNoAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.LbNoAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNoAcc.Location = new System.Drawing.Point(590, 240);
            this.LbNoAcc.Name = "LbNoAcc";
            this.LbNoAcc.Size = new System.Drawing.Size(283, 30);
            this.LbNoAcc.TabIndex = 11;
            this.LbNoAcc.Text = "Already Have An Account ?";
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
            this.BtnClear.Location = new System.Drawing.Point(295, 372);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(200, 45);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.AutoSize = true;
            this.BtnSignUp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnSignUp.Location = new System.Drawing.Point(64, 372);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(200, 45);
            this.BtnSignUp.TabIndex = 1;
            this.BtnSignUp.Text = "SignUp";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.Location = new System.Drawing.Point(340, 182);
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
            this.LbPassword.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(107, 96);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(110, 26);
            this.LbPassword.TabIndex = 8;
            this.LbPassword.Text = "Password";
            this.LbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.Location = new System.Drawing.Point(101, 45);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(116, 26);
            this.LbUsername.TabIndex = 5;
            this.LbUsername.Text = "Username";
            this.LbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(232, 41);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 37);
            this.TxtBxUsername.TabIndex = 4;
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(232, 90);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxPswrd.TabIndex = 5;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Wheat;
            this.LbHeading.Location = new System.Drawing.Point(29, 40);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(436, 43);
            this.LbHeading.TabIndex = 6;
            this.LbHeading.Text = "PRAGATHI E.M. SCHOOL";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbSignUp
            // 
            this.LbSignUp.AutoSize = true;
            this.LbSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSignUp.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSignUp.ForeColor = System.Drawing.Color.Wheat;
            this.LbSignUp.Location = new System.Drawing.Point(795, 102);
            this.LbSignUp.Name = "LbSignUp";
            this.LbSignUp.Size = new System.Drawing.Size(142, 34);
            this.LbSignUp.TabIndex = 5;
            this.LbSignUp.Text = "REGISTER";
            this.LbSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBxUser
            // 
            this.PicBxUser.Image = global::SchoolMS.Properties.Resources.User;
            this.PicBxUser.Location = new System.Drawing.Point(826, 12);
            this.PicBxUser.Name = "PicBxUser";
            this.PicBxUser.Size = new System.Drawing.Size(80, 80);
            this.PicBxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxUser.TabIndex = 4;
            this.PicBxUser.TabStop = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.LbSignUp);
            this.Controls.Add(this.PicBxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegister";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegister_FormClosing);
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label LbNoAcc;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbSignUp;
        private System.Windows.Forms.PictureBox PicBxUser;
        private System.Windows.Forms.Label LbCnfrmPsrd;
        private System.Windows.Forms.TextBox TxtBxCnfrmPswrd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBxSecAns;
        private System.Windows.Forms.ComboBox CmbBxSecQsns;
        private System.Windows.Forms.PictureBox PicBxSchool;
    }
}