namespace SchoolMS
{
    partial class FormTeachers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.DGVTeachers = new System.Windows.Forms.DataGridView();
            this.LbTeachersData = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.TxtBxSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBxSubject = new System.Windows.Forms.ComboBox();
            this.LbSubject = new System.Windows.Forms.Label();
            this.TxtBxPhnNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTchPic = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.PnlTchPic = new System.Windows.Forms.Panel();
            this.PicBxTch = new System.Windows.Forms.PictureBox();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.CmbBxStatus = new System.Windows.Forms.ComboBox();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.TxtBxAddress = new System.Windows.Forms.TextBox();
            this.TxtBxTchId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbStdId = new System.Windows.Forms.Label();
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTeachers)).BeginInit();
            this.Pnl1.SuspendLayout();
            this.PnlTchPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxTch)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbHeading.Location = new System.Drawing.Point(435, 10);
            this.LbHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(109, 24);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "TEACHERS";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.Linen;
            this.Pnl2.Controls.Add(this.DGVTeachers);
            this.Pnl2.Controls.Add(this.LbTeachersData);
            this.Pnl2.Location = new System.Drawing.Point(14, 292);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Pnl2.Size = new System.Drawing.Size(950, 340);
            this.Pnl2.TabIndex = 3;
            // 
            // DGVTeachers
            // 
            this.DGVTeachers.AllowUserToAddRows = false;
            this.DGVTeachers.AllowUserToDeleteRows = false;
            this.DGVTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVTeachers.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVTeachers.ColumnHeadersHeight = 34;
            this.DGVTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVTeachers.EnableHeadersVisualStyles = false;
            this.DGVTeachers.Location = new System.Drawing.Point(5, 35);
            this.DGVTeachers.Name = "DGVTeachers";
            this.DGVTeachers.ReadOnly = true;
            this.DGVTeachers.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVTeachers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVTeachers.RowTemplate.Height = 28;
            this.DGVTeachers.Size = new System.Drawing.Size(940, 290);
            this.DGVTeachers.TabIndex = 3;
            this.DGVTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTeachers_CellClick);
            // 
            // LbTeachersData
            // 
            this.LbTeachersData.AutoSize = true;
            this.LbTeachersData.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTeachersData.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbTeachersData.Location = new System.Drawing.Point(10, 5);
            this.LbTeachersData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTeachersData.Name = "LbTeachersData";
            this.LbTeachersData.Size = new System.Drawing.Size(160, 24);
            this.LbTeachersData.TabIndex = 1;
            this.LbTeachersData.Text = "Teachers\'s Data";
            this.LbTeachersData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.BackColor = System.Drawing.Color.Linen;
            this.Pnl1.Controls.Add(this.TxtBxSalary);
            this.Pnl1.Controls.Add(this.label5);
            this.Pnl1.Controls.Add(this.CmbBxSubject);
            this.Pnl1.Controls.Add(this.LbSubject);
            this.Pnl1.Controls.Add(this.TxtBxPhnNum);
            this.Pnl1.Controls.Add(this.label1);
            this.Pnl1.Controls.Add(this.BtnTchPic);
            this.Pnl1.Controls.Add(this.BtnClear);
            this.Pnl1.Controls.Add(this.BtnDelete);
            this.Pnl1.Controls.Add(this.BtnUpdate);
            this.Pnl1.Controls.Add(this.BtnInsert);
            this.Pnl1.Controls.Add(this.PnlTchPic);
            this.Pnl1.Controls.Add(this.CmbBxGender);
            this.Pnl1.Controls.Add(this.CmbBxStatus);
            this.Pnl1.Controls.Add(this.TxtBxName);
            this.Pnl1.Controls.Add(this.TxtBxAddress);
            this.Pnl1.Controls.Add(this.TxtBxTchId);
            this.Pnl1.Controls.Add(this.label6);
            this.Pnl1.Controls.Add(this.label4);
            this.Pnl1.Controls.Add(this.label3);
            this.Pnl1.Controls.Add(this.label2);
            this.Pnl1.Controls.Add(this.LbStdId);
            this.Pnl1.Location = new System.Drawing.Point(14, 40);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Pnl1.Size = new System.Drawing.Size(950, 240);
            this.Pnl1.TabIndex = 4;
            // 
            // TxtBxSalary
            // 
            this.TxtBxSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxSalary.Location = new System.Drawing.Point(351, 73);
            this.TxtBxSalary.Name = "TxtBxSalary";
            this.TxtBxSalary.Size = new System.Drawing.Size(152, 31);
            this.TxtBxSalary.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(278, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Salary";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbBxSubject
            // 
            this.CmbBxSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxSubject.FormattingEnabled = true;
            this.CmbBxSubject.Items.AddRange(new object[] {
            "Telugu",
            "Hindi",
            "English",
            "Maths",
            "Science",
            "Social",
            "Biology",
            "Physics",
            "Chemistry"});
            this.CmbBxSubject.Location = new System.Drawing.Point(350, 18);
            this.CmbBxSubject.Name = "CmbBxSubject";
            this.CmbBxSubject.Size = new System.Drawing.Size(135, 33);
            this.CmbBxSubject.TabIndex = 44;
            // 
            // LbSubject
            // 
            this.LbSubject.AutoSize = true;
            this.LbSubject.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSubject.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbSubject.Location = new System.Drawing.Point(278, 25);
            this.LbSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSubject.Name = "LbSubject";
            this.LbSubject.Size = new System.Drawing.Size(66, 19);
            this.LbSubject.TabIndex = 30;
            this.LbSubject.Text = "Subject";
            this.LbSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxPhnNum
            // 
            this.TxtBxPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPhnNum.Location = new System.Drawing.Point(578, 127);
            this.TxtBxPhnNum.Name = "TxtBxPhnNum";
            this.TxtBxPhnNum.Size = new System.Drawing.Size(152, 31);
            this.TxtBxPhnNum.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(500, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Phn No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTchPic
            // 
            this.BtnTchPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTchPic.AutoSize = true;
            this.BtnTchPic.BackColor = System.Drawing.Color.Tan;
            this.BtnTchPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTchPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnTchPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTchPic.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.BtnTchPic.Location = new System.Drawing.Point(803, 152);
            this.BtnTchPic.Name = "BtnTchPic";
            this.BtnTchPic.Size = new System.Drawing.Size(131, 31);
            this.BtnTchPic.TabIndex = 41;
            this.BtnTchPic.Text = "Teacher Photo";
            this.BtnTchPic.UseVisualStyleBackColor = false;
            this.BtnTchPic.Click += new System.EventHandler(this.BtnTchPic_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.BackColor = System.Drawing.Color.Tan;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(542, 181);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 40);
            this.BtnClear.TabIndex = 40;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.BackColor = System.Drawing.Color.Tan;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(382, 181);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 40);
            this.BtnDelete.TabIndex = 39;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUpdate.BackColor = System.Drawing.Color.Tan;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(222, 181);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(120, 40);
            this.BtnUpdate.TabIndex = 38;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnInsert.BackColor = System.Drawing.Color.Tan;
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.Location = new System.Drawing.Point(62, 181);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(120, 40);
            this.BtnInsert.TabIndex = 37;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // PnlTchPic
            // 
            this.PnlTchPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTchPic.Controls.Add(this.PicBxTch);
            this.PnlTchPic.Location = new System.Drawing.Point(808, 27);
            this.PnlTchPic.Name = "PnlTchPic";
            this.PnlTchPic.Size = new System.Drawing.Size(120, 120);
            this.PnlTchPic.TabIndex = 36;
            // 
            // PicBxTch
            // 
            this.PicBxTch.BackColor = System.Drawing.Color.DimGray;
            this.PicBxTch.Location = new System.Drawing.Point(0, 0);
            this.PicBxTch.Name = "PicBxTch";
            this.PicBxTch.Size = new System.Drawing.Size(120, 120);
            this.PicBxTch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxTch.TabIndex = 17;
            this.PicBxTch.TabStop = false;
            // 
            // CmbBxGender
            // 
            this.CmbBxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGender.FormattingEnabled = true;
            this.CmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxGender.Location = new System.Drawing.Point(112, 124);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(121, 33);
            this.CmbBxGender.TabIndex = 34;
            // 
            // CmbBxStatus
            // 
            this.CmbBxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxStatus.FormattingEnabled = true;
            this.CmbBxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CmbBxStatus.Location = new System.Drawing.Point(337, 127);
            this.CmbBxStatus.Name = "CmbBxStatus";
            this.CmbBxStatus.Size = new System.Drawing.Size(129, 33);
            this.CmbBxStatus.TabIndex = 32;
            // 
            // TxtBxName
            // 
            this.TxtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxName.Location = new System.Drawing.Point(112, 73);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(152, 31);
            this.TxtBxName.TabIndex = 31;
            // 
            // TxtBxAddress
            // 
            this.TxtBxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxAddress.Location = new System.Drawing.Point(578, 25);
            this.TxtBxAddress.Multiline = true;
            this.TxtBxAddress.Name = "TxtBxAddress";
            this.TxtBxAddress.Size = new System.Drawing.Size(219, 77);
            this.TxtBxAddress.TabIndex = 30;
            // 
            // TxtBxTchId
            // 
            this.TxtBxTchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxTchId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxTchId.Location = new System.Drawing.Point(112, 19);
            this.TxtBxTchId.Name = "TxtBxTchId";
            this.TxtBxTchId.Size = new System.Drawing.Size(152, 31);
            this.TxtBxTchId.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(268, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(497, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "FullName";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(15, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Gender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbStdId
            // 
            this.LbStdId.AutoSize = true;
            this.LbStdId.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStdId.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbStdId.Location = new System.Drawing.Point(15, 25);
            this.LbStdId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbStdId.Name = "LbStdId";
            this.LbStdId.Size = new System.Drawing.Size(88, 19);
            this.LbStdId.TabIndex = 22;
            this.LbStdId.Text = "Teacher Id";
            this.LbStdId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ofd
            // 
            this.Ofd.FileName = "Image File";
            this.Ofd.Filter = "Image File (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            this.Ofd.Title = "Select Teacher Image";
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTeachers";
            this.Text = "School Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTeachers_FormClosing);
            this.Load += new System.EventHandler(this.FormTeachers_Load);
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTeachers)).EndInit();
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.PnlTchPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxTch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.DataGridView DGVTeachers;
        private System.Windows.Forms.Label LbTeachersData;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Button BtnTchPic;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Panel PnlTchPic;
        private System.Windows.Forms.PictureBox PicBxTch;
        private System.Windows.Forms.ComboBox CmbBxGender;
        private System.Windows.Forms.ComboBox CmbBxStatus;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxAddress;
        private System.Windows.Forms.TextBox TxtBxTchId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbStdId;
        private System.Windows.Forms.Label LbSubject;
        private System.Windows.Forms.TextBox TxtBxPhnNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBxSubject;
        private System.Windows.Forms.OpenFileDialog Ofd;
        private System.Windows.Forms.TextBox TxtBxSalary;
        private System.Windows.Forms.Label label5;
    }
}