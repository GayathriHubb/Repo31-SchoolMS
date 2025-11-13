namespace SchoolMS
{
    partial class FormStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.BtnStdPic = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.PnlStdPic = new System.Windows.Forms.Panel();
            this.PicBxStd = new System.Windows.Forms.PictureBox();
            this.CmbBxClass = new System.Windows.Forms.ComboBox();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.CmbBxSection = new System.Windows.Forms.ComboBox();
            this.CmbBxStatus = new System.Windows.Forms.ComboBox();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.TxtBxAddress = new System.Windows.Forms.TextBox();
            this.TxtBxStdId = new System.Windows.Forms.TextBox();
            this.LbStatus = new System.Windows.Forms.Label();
            this.LbSection = new System.Windows.Forms.Label();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbClass = new System.Windows.Forms.Label();
            this.LbStdId = new System.Windows.Forms.Label();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.DGVStudents = new System.Windows.Forms.DataGridView();
            this.LbStudentsData = new System.Windows.Forms.Label();
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            this.Pnl1.SuspendLayout();
            this.PnlStdPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxStd)).BeginInit();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbHeading.Location = new System.Drawing.Point(433, 10);
            this.LbHeading.Margin = new System.Windows.Forms.Padding(0);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(112, 24);
            this.LbHeading.TabIndex = 1;
            this.LbHeading.Text = "STUDENTS";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.BackColor = System.Drawing.Color.Linen;
            this.Pnl1.Controls.Add(this.BtnStdPic);
            this.Pnl1.Controls.Add(this.BtnClear);
            this.Pnl1.Controls.Add(this.BtnDelete);
            this.Pnl1.Controls.Add(this.BtnUpdate);
            this.Pnl1.Controls.Add(this.BtnInsert);
            this.Pnl1.Controls.Add(this.PnlStdPic);
            this.Pnl1.Controls.Add(this.CmbBxClass);
            this.Pnl1.Controls.Add(this.CmbBxGender);
            this.Pnl1.Controls.Add(this.CmbBxSection);
            this.Pnl1.Controls.Add(this.CmbBxStatus);
            this.Pnl1.Controls.Add(this.TxtBxName);
            this.Pnl1.Controls.Add(this.TxtBxAddress);
            this.Pnl1.Controls.Add(this.TxtBxStdId);
            this.Pnl1.Controls.Add(this.LbStatus);
            this.Pnl1.Controls.Add(this.LbSection);
            this.Pnl1.Controls.Add(this.LbAddress);
            this.Pnl1.Controls.Add(this.LbFullName);
            this.Pnl1.Controls.Add(this.label2);
            this.Pnl1.Controls.Add(this.LbClass);
            this.Pnl1.Controls.Add(this.LbStdId);
            this.Pnl1.Location = new System.Drawing.Point(14, 40);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Pnl1.Size = new System.Drawing.Size(950, 240);
            this.Pnl1.TabIndex = 6;
            // 
            // BtnStdPic
            // 
            this.BtnStdPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStdPic.AutoSize = true;
            this.BtnStdPic.BackColor = System.Drawing.Color.Tan;
            this.BtnStdPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStdPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnStdPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStdPic.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.BtnStdPic.Location = new System.Drawing.Point(800, 150);
            this.BtnStdPic.Name = "BtnStdPic";
            this.BtnStdPic.Size = new System.Drawing.Size(131, 31);
            this.BtnStdPic.TabIndex = 21;
            this.BtnStdPic.Text = "Student Photo";
            this.BtnStdPic.UseVisualStyleBackColor = false;
            this.BtnStdPic.Click += new System.EventHandler(this.BtnStdPic_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.BackColor = System.Drawing.Color.Tan;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(534, 179);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 40);
            this.BtnClear.TabIndex = 20;
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
            this.BtnDelete.Location = new System.Drawing.Point(374, 179);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 40);
            this.BtnDelete.TabIndex = 19;
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
            this.BtnUpdate.Location = new System.Drawing.Point(214, 179);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(120, 40);
            this.BtnUpdate.TabIndex = 18;
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
            this.BtnInsert.Location = new System.Drawing.Point(54, 179);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(120, 40);
            this.BtnInsert.TabIndex = 17;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // PnlStdPic
            // 
            this.PnlStdPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlStdPic.Controls.Add(this.PicBxStd);
            this.PnlStdPic.Location = new System.Drawing.Point(805, 25);
            this.PnlStdPic.Name = "PnlStdPic";
            this.PnlStdPic.Size = new System.Drawing.Size(120, 120);
            this.PnlStdPic.TabIndex = 16;
            // 
            // PicBxStd
            // 
            this.PicBxStd.BackColor = System.Drawing.Color.DimGray;
            this.PicBxStd.Location = new System.Drawing.Point(0, 0);
            this.PicBxStd.Name = "PicBxStd";
            this.PicBxStd.Size = new System.Drawing.Size(120, 120);
            this.PicBxStd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxStd.TabIndex = 17;
            this.PicBxStd.TabStop = false;
            // 
            // CmbBxClass
            // 
            this.CmbBxClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxClass.FormattingEnabled = true;
            this.CmbBxClass.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5",
            "Class 6",
            "Class 7",
            "Class 8",
            "Class 9",
            "Class 10"});
            this.CmbBxClass.Location = new System.Drawing.Point(348, 18);
            this.CmbBxClass.Name = "CmbBxClass";
            this.CmbBxClass.Size = new System.Drawing.Size(121, 33);
            this.CmbBxClass.TabIndex = 15;
            // 
            // CmbBxGender
            // 
            this.CmbBxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGender.FormattingEnabled = true;
            this.CmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxGender.Location = new System.Drawing.Point(112, 122);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(121, 33);
            this.CmbBxGender.TabIndex = 14;
            // 
            // CmbBxSection
            // 
            this.CmbBxSection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxSection.FormattingEnabled = true;
            this.CmbBxSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CmbBxSection.Location = new System.Drawing.Point(348, 122);
            this.CmbBxSection.Name = "CmbBxSection";
            this.CmbBxSection.Size = new System.Drawing.Size(121, 33);
            this.CmbBxSection.TabIndex = 13;
            // 
            // CmbBxStatus
            // 
            this.CmbBxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxStatus.FormattingEnabled = true;
            this.CmbBxStatus.Items.AddRange(new object[] {
            "Enrolled ",
            "Graduated",
            "Pending"});
            this.CmbBxStatus.Location = new System.Drawing.Point(565, 122);
            this.CmbBxStatus.Name = "CmbBxStatus";
            this.CmbBxStatus.Size = new System.Drawing.Size(121, 33);
            this.CmbBxStatus.TabIndex = 12;
            // 
            // TxtBxName
            // 
            this.TxtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxName.Location = new System.Drawing.Point(112, 71);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(300, 31);
            this.TxtBxName.TabIndex = 11;
            // 
            // TxtBxAddress
            // 
            this.TxtBxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxAddress.Location = new System.Drawing.Point(565, 25);
            this.TxtBxAddress.Multiline = true;
            this.TxtBxAddress.Name = "TxtBxAddress";
            this.TxtBxAddress.Size = new System.Drawing.Size(219, 77);
            this.TxtBxAddress.TabIndex = 10;
            // 
            // TxtBxStdId
            // 
            this.TxtBxStdId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxStdId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxStdId.Location = new System.Drawing.Point(112, 19);
            this.TxtBxStdId.Name = "TxtBxStdId";
            this.TxtBxStdId.Size = new System.Drawing.Size(152, 31);
            this.TxtBxStdId.TabIndex = 9;
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.LbStatus.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbStatus.Location = new System.Drawing.Point(485, 129);
            this.LbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(56, 19);
            this.LbStatus.TabIndex = 8;
            this.LbStatus.Text = "Status";
            this.LbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbSection
            // 
            this.LbSection.AutoSize = true;
            this.LbSection.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.LbSection.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbSection.Location = new System.Drawing.Point(269, 129);
            this.LbSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSection.Name = "LbSection";
            this.LbSection.Size = new System.Drawing.Size(66, 19);
            this.LbSection.TabIndex = 7;
            this.LbSection.Text = "Section";
            this.LbSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbAddress
            // 
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.LbAddress.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbAddress.Location = new System.Drawing.Point(485, 25);
            this.LbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(69, 19);
            this.LbAddress.TabIndex = 6;
            this.LbAddress.Text = "Address";
            this.LbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbFullName
            // 
            this.LbFullName.AutoSize = true;
            this.LbFullName.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFullName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbFullName.Location = new System.Drawing.Point(15, 77);
            this.LbFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbFullName.Name = "LbFullName";
            this.LbFullName.Size = new System.Drawing.Size(83, 19);
            this.LbFullName.TabIndex = 5;
            this.LbFullName.Text = "FullName";
            this.LbFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbClass
            // 
            this.LbClass.AutoSize = true;
            this.LbClass.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.LbClass.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbClass.Location = new System.Drawing.Point(288, 25);
            this.LbClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbClass.Name = "LbClass";
            this.LbClass.Size = new System.Drawing.Size(47, 19);
            this.LbClass.TabIndex = 3;
            this.LbClass.Text = "Class";
            this.LbClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.LbStdId.TabIndex = 2;
            this.LbStdId.Text = "Student Id";
            this.LbStdId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.Linen;
            this.Pnl2.Controls.Add(this.DGVStudents);
            this.Pnl2.Controls.Add(this.LbStudentsData);
            this.Pnl2.Location = new System.Drawing.Point(14, 290);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Pnl2.Size = new System.Drawing.Size(950, 340);
            this.Pnl2.TabIndex = 5;
            // 
            // DGVStudents
            // 
            this.DGVStudents.AllowUserToAddRows = false;
            this.DGVStudents.AllowUserToDeleteRows = false;
            this.DGVStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVStudents.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStudents.ColumnHeadersHeight = 34;
            this.DGVStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVStudents.EnableHeadersVisualStyles = false;
            this.DGVStudents.Location = new System.Drawing.Point(5, 35);
            this.DGVStudents.Name = "DGVStudents";
            this.DGVStudents.ReadOnly = true;
            this.DGVStudents.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVStudents.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStudents.RowTemplate.Height = 28;
            this.DGVStudents.Size = new System.Drawing.Size(940, 290);
            this.DGVStudents.TabIndex = 3;
            this.DGVStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStudents_CellClick);
            // 
            // LbStudentsData
            // 
            this.LbStudentsData.AutoSize = true;
            this.LbStudentsData.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStudentsData.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbStudentsData.Location = new System.Drawing.Point(10, 5);
            this.LbStudentsData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbStudentsData.Name = "LbStudentsData";
            this.LbStudentsData.Size = new System.Drawing.Size(150, 24);
            this.LbStudentsData.TabIndex = 1;
            this.LbStudentsData.Text = "Student\'s Data";
            this.LbStudentsData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ofd
            // 
            this.Ofd.FileName = "Image File";
            this.Ofd.Filter = "Image File (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            this.Ofd.Title = "Select Student Image";
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormStudents";
            this.Text = "School Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStudents_FormClosing);
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.PnlStdPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxStd)).EndInit();
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.DataGridView DGVStudents;
        private System.Windows.Forms.Label LbStudentsData;
        private System.Windows.Forms.Label LbStdId;
        private System.Windows.Forms.Label LbStatus;
        private System.Windows.Forms.Label LbSection;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbClass;
        private System.Windows.Forms.ComboBox CmbBxClass;
        private System.Windows.Forms.ComboBox CmbBxGender;
        private System.Windows.Forms.ComboBox CmbBxSection;
        private System.Windows.Forms.ComboBox CmbBxStatus;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxAddress;
        private System.Windows.Forms.TextBox TxtBxStdId;
        private System.Windows.Forms.Button BtnStdPic;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Panel PnlStdPic;
        private System.Windows.Forms.PictureBox PicBxStd;
        private System.Windows.Forms.OpenFileDialog Ofd;
    }
}