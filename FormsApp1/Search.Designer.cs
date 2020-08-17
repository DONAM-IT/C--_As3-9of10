namespace FormsApp1
{
    partial class Search
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
            this.tblSearchPage = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNSSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoiSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchPage)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSearchPage
            // 
            this.tblSearchPage.AllowUserToAddRows = false;
            this.tblSearchPage.AllowUserToDeleteRows = false;
            this.tblSearchPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSearchPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSP,
            this.clTenSP,
            this.clsoLuong,
            this.clDonVi,
            this.clNSSX,
            this.clNoiSanXuat,
            this.clGia});
            this.tblSearchPage.Location = new System.Drawing.Point(37, 53);
            this.tblSearchPage.MultiSelect = false;
            this.tblSearchPage.Name = "tblSearchPage";
            this.tblSearchPage.Size = new System.Drawing.Size(727, 345);
            this.tblSearchPage.TabIndex = 35;
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
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblSearchPage);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblSearchPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNSSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoiSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
    }
}