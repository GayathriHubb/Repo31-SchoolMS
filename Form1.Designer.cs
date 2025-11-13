namespace SchoolMS
{
    partial class Form1Load
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
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicBxGif = new System.Windows.Forms.PictureBox();
            this.PicBxSchool = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Snow;
            this.LbHeading.Location = new System.Drawing.Point(124, 190);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(436, 43);
            this.LbHeading.TabIndex = 0;
            this.LbHeading.Text = "PRAGATHI E.M. SCHOOL";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.Controls.Add(this.Pnl2);
            this.Pnl1.Location = new System.Drawing.Point(0, 380);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(678, 30);
            this.Pnl1.TabIndex = 2;
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.Color.LightSlateGray;
            this.Pnl2.Location = new System.Drawing.Point(0, 0);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(80, 30);
            this.Pnl2.TabIndex = 0;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 20;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PicBxGif
            // 
            this.PicBxGif.Image = global::SchoolMS.Properties.Resources.Loading2Circles;
            this.PicBxGif.Location = new System.Drawing.Point(479, 290);
            this.PicBxGif.Name = "PicBxGif";
            this.PicBxGif.Size = new System.Drawing.Size(80, 80);
            this.PicBxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGif.TabIndex = 3;
            this.PicBxGif.TabStop = false;
            // 
            // PicBxSchool
            // 
            this.PicBxSchool.Image = global::SchoolMS.Properties.Resources.School;
            this.PicBxSchool.Location = new System.Drawing.Point(259, 20);
            this.PicBxSchool.Name = "PicBxSchool";
            this.PicBxSchool.Size = new System.Drawing.Size(150, 150);
            this.PicBxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxSchool.TabIndex = 1;
            this.PicBxSchool.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ysabeau", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loading...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBxGif);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.PicBxSchool);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1Load";
            this.Text = "School Management System";
            this.Pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.PictureBox PicBxSchool;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.PictureBox PicBxGif;
        private System.Windows.Forms.Label label1;
    }
}

