namespace FormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNoiSanXuat = new System.Windows.Forms.ComboBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.BtnSavetoFile = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnLoadfromFile = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radChai = new System.Windows.Forms.RadioButton();
            this.radThung = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.dTPDOB = new System.Windows.Forms.DateTimePicker();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNSSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoiSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbNoiSanXuat);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.bntExit);
            this.groupBox1.Controls.Add(this.BtnSavetoFile);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.BtnLoadfromFile);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.dTPDOB);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(409, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản Phẩm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(98, 88);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(270, 29);
            this.txtSoLuong.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(125, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Chúc Bạn Ngày An Lành !!!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbNoiSanXuat
            // 
            this.cbNoiSanXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoiSanXuat.FormattingEnabled = true;
            this.cbNoiSanXuat.Items.AddRange(new object[] {
            "Vietnam",
            "Japan",
            "China",
            "Thailand",
            "Laos",
            "Indonesia",
            "Philipin"});
            this.cbNoiSanXuat.Location = new System.Drawing.Point(84, 209);
            this.cbNoiSanXuat.Name = "cbNoiSanXuat";
            this.cbNoiSanXuat.Size = new System.Drawing.Size(284, 29);
            this.cbNoiSanXuat.TabIndex = 40;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(98, 19);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(270, 29);
            this.txtMaSP.TabIndex = 39;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(29, 293);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(96, 33);
            this.BtnNew.TabIndex = 35;
            this.BtnNew.Text = "Làm sạch";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click_1);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(163, 317);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 28);
            this.bntExit.TabIndex = 3;
            this.bntExit.Text = "Thoát";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // BtnSavetoFile
            // 
            this.BtnSavetoFile.Location = new System.Drawing.Point(29, 366);
            this.BtnSavetoFile.Name = "BtnSavetoFile";
            this.BtnSavetoFile.Size = new System.Drawing.Size(96, 39);
            this.BtnSavetoFile.TabIndex = 37;
            this.BtnSavetoFile.Text = "Lưu lại";
            this.BtnSavetoFile.UseVisualStyleBackColor = true;
            this.BtnSavetoFile.Click += new System.EventHandler(this.BtnSavetoFile_Click_1);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(272, 293);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 33);
            this.BtnAdd.TabIndex = 36;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnLoadfromFile
            // 
            this.BtnLoadfromFile.Location = new System.Drawing.Point(272, 366);
            this.BtnLoadfromFile.Name = "BtnLoadfromFile";
            this.BtnLoadfromFile.Size = new System.Drawing.Size(96, 39);
            this.BtnLoadfromFile.TabIndex = 38;
            this.BtnLoadfromFile.Text = "Tải lên";
            this.BtnLoadfromFile.UseVisualStyleBackColor = true;
            this.BtnLoadfromFile.Click += new System.EventHandler(this.BtnLoadfromFile_Click_1);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(281, 53);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(87, 29);
            this.BtnSearch.TabIndex = 27;
            this.BtnSearch.Text = "Tìm kiếm";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Số Lượng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radChai);
            this.groupBox2.Controls.Add(this.radThung);
            this.groupBox2.Location = new System.Drawing.Point(98, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 30);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // radChai
            // 
            this.radChai.AutoSize = true;
            this.radChai.Location = new System.Drawing.Point(30, 11);
            this.radChai.Name = "radChai";
            this.radChai.Size = new System.Drawing.Size(62, 25);
            this.radChai.TabIndex = 3;
            this.radChai.TabStop = true;
            this.radChai.Text = "Chai";
            this.radChai.UseVisualStyleBackColor = true;
            // 
            // radThung
            // 
            this.radThung.AutoSize = true;
            this.radThung.Location = new System.Drawing.Point(183, 8);
            this.radThung.Name = "radThung";
            this.radThung.Size = new System.Drawing.Size(76, 25);
            this.radThung.TabIndex = 4;
            this.radThung.TabStop = true;
            this.radThung.Text = "Thùng";
            this.radThung.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "NSSX:";
            // 
            // txtGia
            // 
            this.txtGia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGia.Location = new System.Drawing.Point(84, 253);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(284, 29);
            this.txtGia.TabIndex = 2;
            // 
            // dTPDOB
            // 
            this.dTPDOB.Location = new System.Drawing.Point(84, 161);
            this.dTPDOB.Name = "dTPDOB";
            this.dTPDOB.Size = new System.Drawing.Size(284, 29);
            this.dTPDOB.TabIndex = 9;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(98, 55);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(140, 29);
            this.txtTenSP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nơi sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn Vị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SP:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgEmployees
            // 
            this.dgEmployees.AllowUserToAddRows = false;
            this.dgEmployees.AllowUserToDeleteRows = false;
            this.dgEmployees.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSP,
            this.clTenSP,
            this.clsoLuong,
            this.clDonVi,
            this.clNSSX,
            this.clNoiSanXuat,
            this.clGia});
            this.dgEmployees.Location = new System.Drawing.Point(427, 62);
            this.dgEmployees.MultiSelect = false;
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.Size = new System.Drawing.Size(888, 398);
            this.dgEmployees.TabIndex = 34;
            this.dgEmployees.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEmployees_CellMouseClick);
            // 
            // clMaSP
            // 
            this.clMaSP.HeaderText = "Mã SP";
            this.clMaSP.Name = "clMaSP";
            // 
            // clTenSP
            // 
            this.clTenSP.HeaderText = "Tên SP";
            this.clTenSP.Name = "clTenSP";
            // 
            // clsoLuong
            // 
            this.clsoLuong.HeaderText = "Số Lượng";
            this.clsoLuong.Name = "clsoLuong";
            // 
            // clDonVi
            // 
            this.clDonVi.HeaderText = "Đơn Vị";
            this.clDonVi.Name = "clDonVi";
            // 
            // clNSSX
            // 
            this.clNSSX.HeaderText = "NSSX";
            this.clNSSX.Name = "clNSSX";
            // 
            // clNoiSanXuat
            // 
            this.clNoiSanXuat.HeaderText = "Nơi sản xuất";
            this.clNoiSanXuat.Name = "clNoiSanXuat";
            // 
            // clGia
            // 
            this.clGia.HeaderText = "Giá";
            this.clGia.Name = "clGia";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(436, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 900;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 47);
            this.button1.TabIndex = 901;
            this.button1.Text = "Chào mừng bạn đã đến với phần mềm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsApp1.Properties.Resources.apple;
            this.pictureBox1.Location = new System.Drawing.Point(774, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 902;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::FormsApp1.Properties.Resources.pm7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgEmployees);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DateTimePicker dTPDOB;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radChai;
        private System.Windows.Forms.RadioButton radThung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSavetoFile;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnLoadfromFile;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNSSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoiSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.ComboBox cbNoiSanXuat;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

