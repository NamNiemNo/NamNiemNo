namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgDanhSach = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTen = new TextBox();
            txtMoTa = new TextBox();
            txtLoaiHang = new TextBox();
            dtNgayDangKy = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            cbbDiaChi = new ComboBox();
            label5 = new Label();
            txtSearch = new TextBox();
            cbbTrungTam = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSach).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSach
            // 
            dtgDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSach.Location = new Point(6, 338);
            dtgDanhSach.Name = "dtgDanhSach";
            dtgDanhSach.RowHeadersWidth = 51;
            dtgDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSach.Size = new Size(909, 198);
            dtgDanhSach.TabIndex = 0;
            dtgDanhSach.CellClick += dtgDanhSach_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 89);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 2;
            label2.Text = "MoTa :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 145);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 3;
            label3.Text = "Loại Hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 203);
            label4.Name = "label4";
            label4.Size = new Size(158, 28);
            label4.TabIndex = 4;
            label4.Text = "Ngày Đăng Ký :";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(206, 34);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(217, 27);
            txtTen.TabIndex = 5;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(206, 93);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(217, 27);
            txtMoTa.TabIndex = 6;
            // 
            // txtLoaiHang
            // 
            txtLoaiHang.Location = new Point(206, 149);
            txtLoaiHang.Name = "txtLoaiHang";
            txtLoaiHang.Size = new Size(217, 27);
            txtLoaiHang.TabIndex = 7;
            txtLoaiHang.TextChanged += txtLoaiHang_TextChanged;
            // 
            // dtNgayDangKy
            // 
            dtNgayDangKy.Format = DateTimePickerFormat.Short;
            dtNgayDangKy.Location = new Point(206, 205);
            dtNgayDangKy.Name = "dtNgayDangKy";
            dtNgayDangKy.Size = new Size(218, 27);
            dtNgayDangKy.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(730, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 66);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(558, 34);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 66);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(652, 129);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 66);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // cbbDiaChi
            // 
            cbbDiaChi.FormattingEnabled = true;
            cbbDiaChi.Location = new Point(206, 259);
            cbbDiaChi.Name = "cbbDiaChi";
            cbbDiaChi.Size = new Size(217, 28);
            cbbDiaChi.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 259);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 13;
            label5.Text = "Địa Chỉ :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(521, 290);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(381, 27);
            txtSearch.TabIndex = 14;
            txtSearch.Text = "Tim Kiem";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cbbTrungTam
            // 
            cbbTrungTam.FormattingEnabled = true;
            cbbTrungTam.Location = new Point(630, 234);
            cbbTrungTam.Name = "cbbTrungTam";
            cbbTrungTam.Size = new Size(217, 28);
            cbbTrungTam.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cbbTrungTam);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(cbbDiaChi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dtNgayDangKy);
            Controls.Add(txtLoaiHang);
            Controls.Add(txtMoTa);
            Controls.Add(txtTen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgDanhSach);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDanhSach;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTen;
        private TextBox txtMoTa;
        private TextBox txtLoaiHang;
        private DateTimePicker dtNgayDangKy;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private ComboBox cbbDiaChi;
        private Label label5;
        private TextBox txtSearch;
        private ComboBox cbbTrungTam;
    }
}
