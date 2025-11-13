namespace SchoolMS
{
    partial class FormDashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbEnrStds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PicBx2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LbGrdStds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PicBx3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbTotTchs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PicBx1 = new System.Windows.Forms.PictureBox();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.DGVDashBoard = new System.Windows.Forms.DataGridView();
            this.LbEnrStsTod = new System.Windows.Forms.Label();
            this.Pnl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx1)).BeginInit();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDashBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbHeading.Location = new System.Drawing.Point(452, 2);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(135, 24);
            this.LbHeading.TabIndex = 0;
            this.LbHeading.Text = "DASHBOARD";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.BackColor = System.Drawing.Color.Linen;
            this.Pnl1.Controls.Add(this.panel3);
            this.Pnl1.Controls.Add(this.panel4);
            this.Pnl1.Controls.Add(this.panel2);
            this.Pnl1.Location = new System.Drawing.Point(7, 30);
            this.Pnl1.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(965, 200);
            this.Pnl1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Controls.Add(this.LbEnrStds);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.PicBx2);
            this.panel3.Location = new System.Drawing.Point(342, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 160);
            this.panel3.TabIndex = 0;
            // 
            // LbEnrStds
            // 
            this.LbEnrStds.AutoSize = true;
            this.LbEnrStds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbEnrStds.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEnrStds.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbEnrStds.Location = new System.Drawing.Point(15, 117);
            this.LbEnrStds.Name = "LbEnrStds";
            this.LbEnrStds.Size = new System.Drawing.Size(31, 34);
            this.LbEnrStds.TabIndex = 7;
            this.LbEnrStds.Text = "0";
            this.LbEnrStds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(105, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enrolled \r\nStudents";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBx2
            // 
            this.PicBx2.Image = global::SchoolMS.Properties.Resources.Students;
            this.PicBx2.Location = new System.Drawing.Point(15, 17);
            this.PicBx2.Margin = new System.Windows.Forms.Padding(2);
            this.PicBx2.Name = "PicBx2";
            this.PicBx2.Size = new System.Drawing.Size(75, 83);
            this.PicBx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx2.TabIndex = 5;
            this.PicBx2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Controls.Add(this.LbGrdStds);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.PicBx3);
            this.panel4.Location = new System.Drawing.Point(674, 20);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 160);
            this.panel4.TabIndex = 0;
            // 
            // LbGrdStds
            // 
            this.LbGrdStds.AutoSize = true;
            this.LbGrdStds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbGrdStds.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGrdStds.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbGrdStds.Location = new System.Drawing.Point(15, 117);
            this.LbGrdStds.Name = "LbGrdStds";
            this.LbGrdStds.Size = new System.Drawing.Size(31, 34);
            this.LbGrdStds.TabIndex = 8;
            this.LbGrdStds.Text = "0";
            this.LbGrdStds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(105, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Graduated \r\nStudents";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBx3
            // 
            this.PicBx3.Image = global::SchoolMS.Properties.Resources.Graduated;
            this.PicBx3.Location = new System.Drawing.Point(15, 17);
            this.PicBx3.Margin = new System.Windows.Forms.Padding(2);
            this.PicBx3.Name = "PicBx3";
            this.PicBx3.Size = new System.Drawing.Size(75, 83);
            this.PicBx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx3.TabIndex = 5;
            this.PicBx3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.LbTotTchs);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.PicBx1);
            this.panel2.Location = new System.Drawing.Point(10, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 160);
            this.panel2.TabIndex = 0;
            // 
            // LbTotTchs
            // 
            this.LbTotTchs.AutoSize = true;
            this.LbTotTchs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTotTchs.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotTchs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbTotTchs.Location = new System.Drawing.Point(15, 117);
            this.LbTotTchs.Name = "LbTotTchs";
            this.LbTotTchs.Size = new System.Drawing.Size(31, 34);
            this.LbTotTchs.TabIndex = 6;
            this.LbTotTchs.Text = "0";
            this.LbTotTchs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(105, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total \r\nTeachers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBx1
            // 
            this.PicBx1.Image = global::SchoolMS.Properties.Resources.Teacher;
            this.PicBx1.Location = new System.Drawing.Point(15, 17);
            this.PicBx1.Margin = new System.Windows.Forms.Padding(2);
            this.PicBx1.Name = "PicBx1";
            this.PicBx1.Size = new System.Drawing.Size(75, 83);
            this.PicBx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx1.TabIndex = 4;
            this.PicBx1.TabStop = false;
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.Linen;
            this.Pnl2.Controls.Add(this.DGVDashBoard);
            this.Pnl2.Controls.Add(this.LbEnrStsTod);
            this.Pnl2.Location = new System.Drawing.Point(7, 238);
            this.Pnl2.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(965, 400);
            this.Pnl2.TabIndex = 2;
            // 
            // DGVDashBoard
            // 
            this.DGVDashBoard.AllowUserToAddRows = false;
            this.DGVDashBoard.AllowUserToDeleteRows = false;
            this.DGVDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDashBoard.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDashBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVDashBoard.ColumnHeadersHeight = 34;
            this.DGVDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVDashBoard.EnableHeadersVisualStyles = false;
            this.DGVDashBoard.Location = new System.Drawing.Point(0, 29);
            this.DGVDashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.DGVDashBoard.Name = "DGVDashBoard";
            this.DGVDashBoard.ReadOnly = true;
            this.DGVDashBoard.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVDashBoard.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVDashBoard.RowTemplate.Height = 28;
            this.DGVDashBoard.Size = new System.Drawing.Size(965, 358);
            this.DGVDashBoard.TabIndex = 3;
            // 
            // LbEnrStsTod
            // 
            this.LbEnrStsTod.AutoSize = true;
            this.LbEnrStsTod.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEnrStsTod.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbEnrStsTod.Location = new System.Drawing.Point(4, 4);
            this.LbEnrStsTod.Name = "LbEnrStsTod";
            this.LbEnrStsTod.Size = new System.Drawing.Size(218, 21);
            this.LbEnrStsTod.TabIndex = 1;
            this.LbEnrStsTod.Text = "Enrolled Students Today";
            this.LbEnrStsTod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDashBoard";
            this.Text = "School Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDashBoard_FormClosing);
            this.Load += new System.EventHandler(this.FormDashBoard_Load);
            this.Pnl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx1)).EndInit();
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDashBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVDashBoard;
        private System.Windows.Forms.Label LbEnrStsTod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicBx2;
        private System.Windows.Forms.PictureBox PicBx3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PicBx1;
        private System.Windows.Forms.Label LbEnrStds;
        private System.Windows.Forms.Label LbGrdStds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbTotTchs;
    }
}