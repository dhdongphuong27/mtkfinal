namespace QuanLyShopHoa
{
    partial class frmHD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgayHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnEditHD = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dotGiamGiaComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMucGiam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loaiGiamGiaComboBox = new System.Windows.Forms.ComboBox();
            this.btnXoaHH = new System.Windows.Forms.Button();
            this.btnThemHH = new System.Windows.Forms.Button();
            this.btnUpdateHD = new System.Windows.Forms.Button();
            this.tvThanhTien = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tvDonGia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tvTenHH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvSauGiam = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.tvTongTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.clMaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnEditHD.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNgayHD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSoHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(19, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 72);
            this.panel1.TabIndex = 16;
            // 
            // txtNgayHD
            // 
            this.txtNgayHD.Location = new System.Drawing.Point(114, 36);
            this.txtNgayHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayHD.Name = "txtNgayHD";
            this.txtNgayHD.Size = new System.Drawing.Size(108, 20);
            this.txtNgayHD.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày lập:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(114, 13);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(108, 20);
            this.txtSoHD.TabIndex = 5;
            this.txtSoHD.TextChanged += new System.EventHandler(this.txtSoHD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số hóa đơn:";
            // 
            // pnEditHD
            // 
            this.pnEditHD.Controls.Add(this.label12);
            this.pnEditHD.Controls.Add(this.dotGiamGiaComboBox);
            this.pnEditHD.Controls.Add(this.label9);
            this.pnEditHD.Controls.Add(this.txtMucGiam);
            this.pnEditHD.Controls.Add(this.label6);
            this.pnEditHD.Controls.Add(this.loaiGiamGiaComboBox);
            this.pnEditHD.Controls.Add(this.btnXoaHH);
            this.pnEditHD.Controls.Add(this.btnThemHH);
            this.pnEditHD.Controls.Add(this.btnUpdateHD);
            this.pnEditHD.Controls.Add(this.tvThanhTien);
            this.pnEditHD.Controls.Add(this.label10);
            this.pnEditHD.Controls.Add(this.txtSL);
            this.pnEditHD.Controls.Add(this.label8);
            this.pnEditHD.Controls.Add(this.tvDonGia);
            this.pnEditHD.Controls.Add(this.label7);
            this.pnEditHD.Controls.Add(this.tvTenHH);
            this.pnEditHD.Controls.Add(this.label4);
            this.pnEditHD.Controls.Add(this.txtMaHH);
            this.pnEditHD.Controls.Add(this.label3);
            this.pnEditHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEditHD.Location = new System.Drawing.Point(19, 92);
            this.pnEditHD.Margin = new System.Windows.Forms.Padding(2);
            this.pnEditHD.Name = "pnEditHD";
            this.pnEditHD.Size = new System.Drawing.Size(450, 175);
            this.pnEditHD.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Đợt giảm giá:";
            // 
            // dotGiamGiaComboBox
            // 
            this.dotGiamGiaComboBox.FormattingEnabled = true;
            this.dotGiamGiaComboBox.Items.AddRange(new object[] {
            "Không giảm",
            "Giảm cuối tuần",
            "Giảm cuối năm"});
            this.dotGiamGiaComboBox.Location = new System.Drawing.Point(335, 14);
            this.dotGiamGiaComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.dotGiamGiaComboBox.Name = "dotGiamGiaComboBox";
            this.dotGiamGiaComboBox.Size = new System.Drawing.Size(92, 21);
            this.dotGiamGiaComboBox.TabIndex = 33;
            this.dotGiamGiaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Mức giảm giá:";
            // 
            // txtMucGiam
            // 
            this.txtMucGiam.Enabled = false;
            this.txtMucGiam.Location = new System.Drawing.Point(335, 103);
            this.txtMucGiam.Margin = new System.Windows.Forms.Padding(2);
            this.txtMucGiam.Name = "txtMucGiam";
            this.txtMucGiam.Size = new System.Drawing.Size(92, 20);
            this.txtMucGiam.TabIndex = 31;
            this.txtMucGiam.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Loại giảm giá:";
            // 
            // loaiGiamGiaComboBox
            // 
            this.loaiGiamGiaComboBox.Enabled = false;
            this.loaiGiamGiaComboBox.FormattingEnabled = true;
            this.loaiGiamGiaComboBox.Items.AddRange(new object[] {
            "Không giảm giá",
            "Giảm theo %",
            "Giảm trực tiếp"});
            this.loaiGiamGiaComboBox.Location = new System.Drawing.Point(335, 74);
            this.loaiGiamGiaComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.loaiGiamGiaComboBox.Name = "loaiGiamGiaComboBox";
            this.loaiGiamGiaComboBox.Size = new System.Drawing.Size(92, 21);
            this.loaiGiamGiaComboBox.TabIndex = 29;
            this.loaiGiamGiaComboBox.SelectedIndexChanged += new System.EventHandler(this.loaiGiamGiaComboBox_SelectedIndexChanged);
            // 
            // btnXoaHH
            // 
            this.btnXoaHH.AutoSize = true;
            this.btnXoaHH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHH.Location = new System.Drawing.Point(178, 144);
            this.btnXoaHH.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaHH.Name = "btnXoaHH";
            this.btnXoaHH.Size = new System.Drawing.Size(39, 23);
            this.btnXoaHH.TabIndex = 28;
            this.btnXoaHH.Text = "Xóa";
            this.btnXoaHH.UseVisualStyleBackColor = true;
            this.btnXoaHH.Click += new System.EventHandler(this.btnXoaHH_Click);
            // 
            // btnThemHH
            // 
            this.btnThemHH.AutoSize = true;
            this.btnThemHH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHH.Location = new System.Drawing.Point(114, 144);
            this.btnThemHH.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHH.Name = "btnThemHH";
            this.btnThemHH.Size = new System.Drawing.Size(48, 23);
            this.btnThemHH.TabIndex = 27;
            this.btnThemHH.Text = "Thêm";
            this.btnThemHH.UseVisualStyleBackColor = true;
            this.btnThemHH.Click += new System.EventHandler(this.btnThemHH_Click);
            // 
            // btnUpdateHD
            // 
            this.btnUpdateHD.AutoSize = true;
            this.btnUpdateHD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHD.Location = new System.Drawing.Point(365, 144);
            this.btnUpdateHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateHD.Name = "btnUpdateHD";
            this.btnUpdateHD.Size = new System.Drawing.Size(68, 23);
            this.btnUpdateHD.TabIndex = 26;
            this.btnUpdateHD.Text = "Cập nhật";
            this.btnUpdateHD.UseVisualStyleBackColor = true;
            this.btnUpdateHD.Click += new System.EventHandler(this.btnUpdateHD_Click);
            // 
            // tvThanhTien
            // 
            this.tvThanhTien.AutoSize = true;
            this.tvThanhTien.Location = new System.Drawing.Point(114, 115);
            this.tvThanhTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tvThanhTien.Name = "tvThanhTien";
            this.tvThanhTien.Size = new System.Drawing.Size(0, 13);
            this.tvThanhTien.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Thành tiền:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(114, 88);
            this.txtSL.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(108, 20);
            this.txtSL.TabIndex = 23;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Số lượng:";
            // 
            // tvDonGia
            // 
            this.tvDonGia.AutoSize = true;
            this.tvDonGia.Location = new System.Drawing.Point(114, 63);
            this.tvDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tvDonGia.Name = "tvDonGia";
            this.tvDonGia.Size = new System.Drawing.Size(0, 13);
            this.tvDonGia.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Đơn giá:";
            // 
            // tvTenHH
            // 
            this.tvTenHH.AutoSize = true;
            this.tvTenHH.Location = new System.Drawing.Point(114, 41);
            this.tvTenHH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tvTenHH.Name = "tvTenHH";
            this.tvTenHH.Size = new System.Drawing.Size(0, 13);
            this.tvTenHH.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên hàng hóa:";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(114, 14);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(108, 20);
            this.txtMaHH.TabIndex = 17;
            this.txtMaHH.Leave += new System.EventHandler(this.txtMaHH_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã hàng hóa:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(364, 32);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(82, 23);
            this.btnThanhToan.TabIndex = 28;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvSauGiam);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.tvTongTien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(19, 396);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 56);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tvSauGiam
            // 
            this.tvSauGiam.AutoSize = true;
            this.tvSauGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvSauGiam.Location = new System.Drawing.Point(93, 33);
            this.tvSauGiam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tvSauGiam.Name = "tvSauGiam";
            this.tvSauGiam.Size = new System.Drawing.Size(0, 17);
            this.tvSauGiam.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Sau giảm:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.AutoSize = true;
            this.btnTinhTien.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(364, 10);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(2);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(85, 23);
            this.btnTinhTien.TabIndex = 33;
            this.btnTinhTien.Text = "  Tính tiền  ";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.button1_Click);
            // 
            // tvTongTien
            // 
            this.tvTongTien.AutoSize = true;
            this.tvTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvTongTien.Location = new System.Drawing.Point(93, 10);
            this.tvTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tvTongTien.Name = "tvTongTien";
            this.tvTongTien.Size = new System.Drawing.Size(0, 17);
            this.tvTongTien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền:";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaHH,
            this.clTenHH,
            this.clDonGia,
            this.clSL,
            this.clThanhTien});
            this.dgvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonHang.Location = new System.Drawing.Point(19, 267);
            this.dgvDonHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(450, 129);
            this.dgvDonHang.TabIndex = 19;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // clMaHH
            // 
            this.clMaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clMaHH.DataPropertyName = "MaHH";
            this.clMaHH.HeaderText = "Mã";
            this.clMaHH.MinimumWidth = 6;
            this.clMaHH.Name = "clMaHH";
            this.clMaHH.ReadOnly = true;
            this.clMaHH.Width = 47;
            // 
            // clTenHH
            // 
            this.clTenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clTenHH.DataPropertyName = "TenHH";
            this.clTenHH.HeaderText = "Tên hàng hóa";
            this.clTenHH.MinimumWidth = 6;
            this.clTenHH.Name = "clTenHH";
            this.clTenHH.ReadOnly = true;
            this.clTenHH.Width = 91;
            // 
            // clDonGia
            // 
            this.clDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDonGia.DataPropertyName = "DonGia";
            this.clDonGia.HeaderText = "Giá";
            this.clDonGia.MinimumWidth = 6;
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            this.clDonGia.Width = 48;
            // 
            // clSL
            // 
            this.clSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clSL.DataPropertyName = "SL";
            this.clSL.HeaderText = "Số lượng";
            this.clSL.MinimumWidth = 6;
            this.clSL.Name = "clSL";
            this.clSL.ReadOnly = true;
            this.clSL.Width = 69;
            // 
            // clThanhTien
            // 
            this.clThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clThanhTien.DataPropertyName = "ThanhTien";
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.MinimumWidth = 6;
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            // 
            // frmHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 472);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnEditHD);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHD";
            this.Padding = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnEditHD.ResumeLayout(false);
            this.pnEditHD.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNgayHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnEditHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThemHH;
        private System.Windows.Forms.Button btnUpdateHD;
        private System.Windows.Forms.Label tvThanhTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tvDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tvTenHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tvTongTien;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Button btnXoaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMucGiam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox loaiGiamGiaComboBox;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tvSauGiam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox dotGiamGiaComboBox;
    }
}