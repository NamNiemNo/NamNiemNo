namespace Gui
{
    partial class San_Pham
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dtagrv = new DataGridView();
            CbbNcc = new ComboBox();
            TxtSotien = new TextBox();
            TxtSoluongton = new TextBox();
            txtMota = new TextBox();
            txtSp = new TextBox();
            txtSe = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtagrv).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(429, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(564, 85);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(690, 85);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtagrv
            // 
            dtagrv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtagrv.Location = new Point(17, 252);
            dtagrv.Name = "dtagrv";
            dtagrv.RowHeadersWidth = 51;
            dtagrv.Size = new Size(767, 188);
            dtagrv.TabIndex = 28;
            dtagrv.CellClick += dtagrv_CellClick;
            // 
            // CbbNcc
            // 
            CbbNcc.FormattingEnabled = true;
            CbbNcc.Location = new Point(122, 211);
            CbbNcc.Name = "CbbNcc";
            CbbNcc.Size = new Size(271, 28);
            CbbNcc.TabIndex = 27;
            // 
            // TxtSotien
            // 
            TxtSotien.Location = new Point(122, 175);
            TxtSotien.Name = "TxtSotien";
            TxtSotien.Size = new Size(271, 27);
            TxtSotien.TabIndex = 26;
            // 
            // TxtSoluongton
            // 
            TxtSoluongton.Location = new Point(122, 132);
            TxtSoluongton.Name = "TxtSoluongton";
            TxtSoluongton.Size = new Size(271, 27);
            TxtSoluongton.TabIndex = 25;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(122, 82);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(271, 27);
            txtMota.TabIndex = 24;
            // 
            // txtSp
            // 
            txtSp.Location = new Point(122, 44);
            txtSp.Name = "txtSp";
            txtSp.Size = new Size(271, 27);
            txtSp.TabIndex = 23;
            // 
            // txtSe
            // 
            txtSe.Location = new Point(500, 175);
            txtSe.Name = "txtSe";
            txtSe.Size = new Size(288, 27);
            txtSe.TabIndex = 22;
            txtSe.TextChanged += txtSe_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 211);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 21;
            label6.Text = "Nhà cung cấp ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 175);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 20;
            label5.Text = "Giá tiền ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 19;
            label4.Text = "Số Lượng Tồn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 89);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 18;
            label3.Text = "Mô Tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 44);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 17;
            label2.Text = "Tên Sp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 178);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 16;
            label1.Text = "Tìm kiếm ";
            // 
            // San_Pham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtagrv);
            Controls.Add(CbbNcc);
            Controls.Add(TxtSotien);
            Controls.Add(TxtSoluongton);
            Controls.Add(txtMota);
            Controls.Add(txtSp);
            Controls.Add(txtSe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "San_Pham";
            Text = "San_Pham";
            ((System.ComponentModel.ISupportInitialize)dtagrv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dtagrv;
        private ComboBox CbbNcc;
        private TextBox TxtSotien;
        private TextBox TxtSoluongton;
        private TextBox txtMota;
        private TextBox txtSp;
        private TextBox txtSe;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}