
namespace QL_NHAHANG
{
    partial class frm_Ban
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
            this.cb_Ban = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaMonAn = new System.Windows.Forms.TextBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ThemB = new System.Windows.Forms.Button();
            this.btn_SuaB = new System.Windows.Forms.Button();
            this.btn_XoaB = new System.Windows.Forms.Button();
            this.txt_TenMonAn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoLuongMonAn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SoLuongDU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenDoUong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaDoUong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_STT = new System.Windows.Forms.TextBox();
            this.txt_MaBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Ban
            // 
            this.cb_Ban.FormattingEnabled = true;
            this.cb_Ban.Location = new System.Drawing.Point(259, 68);
            this.cb_Ban.Name = "cb_Ban";
            this.cb_Ban.Size = new System.Drawing.Size(121, 24);
            this.cb_Ban.TabIndex = 0;
            this.cb_Ban.SelectedIndexChanged += new System.EventHandler(this.cb_Ban_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Món Ăn";
            // 
            // txt_MaMonAn
            // 
            this.txt_MaMonAn.Location = new System.Drawing.Point(227, 152);
            this.txt_MaMonAn.Name = "txt_MaMonAn";
            this.txt_MaMonAn.Size = new System.Drawing.Size(177, 22);
            this.txt_MaMonAn.TabIndex = 3;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Location = new System.Drawing.Point(566, 60);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(166, 33);
            this.btn_Menu.TabIndex = 4;
            this.btn_Menu.Text = "Xem Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "BÀN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 238);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_ThemB
            // 
            this.btn_ThemB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemB.Location = new System.Drawing.Point(178, 268);
            this.btn_ThemB.Name = "btn_ThemB";
            this.btn_ThemB.Size = new System.Drawing.Size(93, 33);
            this.btn_ThemB.TabIndex = 9;
            this.btn_ThemB.Text = "Thêm";
            this.btn_ThemB.UseVisualStyleBackColor = true;
            this.btn_ThemB.Click += new System.EventHandler(this.btn_ThemB_Click);
            // 
            // btn_SuaB
            // 
            this.btn_SuaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaB.Location = new System.Drawing.Point(328, 268);
            this.btn_SuaB.Name = "btn_SuaB";
            this.btn_SuaB.Size = new System.Drawing.Size(93, 33);
            this.btn_SuaB.TabIndex = 10;
            this.btn_SuaB.Text = "Sửa";
            this.btn_SuaB.UseVisualStyleBackColor = true;
            this.btn_SuaB.Click += new System.EventHandler(this.btn_SuaB_Click);
            // 
            // btn_XoaB
            // 
            this.btn_XoaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaB.Location = new System.Drawing.Point(487, 268);
            this.btn_XoaB.Name = "btn_XoaB";
            this.btn_XoaB.Size = new System.Drawing.Size(93, 33);
            this.btn_XoaB.TabIndex = 11;
            this.btn_XoaB.Text = "Xóa";
            this.btn_XoaB.UseVisualStyleBackColor = true;
            this.btn_XoaB.Click += new System.EventHandler(this.btn_XoaB_Click);
            // 
            // txt_TenMonAn
            // 
            this.txt_TenMonAn.Location = new System.Drawing.Point(227, 191);
            this.txt_TenMonAn.Name = "txt_TenMonAn";
            this.txt_TenMonAn.Size = new System.Drawing.Size(177, 22);
            this.txt_TenMonAn.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên Món Ăn";
            // 
            // txt_SoLuongMonAn
            // 
            this.txt_SoLuongMonAn.Location = new System.Drawing.Point(227, 228);
            this.txt_SoLuongMonAn.Name = "txt_SoLuongMonAn";
            this.txt_SoLuongMonAn.Size = new System.Drawing.Size(177, 22);
            this.txt_SoLuongMonAn.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số Lượng";
            // 
            // txt_SoLuongDU
            // 
            this.txt_SoLuongDU.Location = new System.Drawing.Point(566, 228);
            this.txt_SoLuongDU.Name = "txt_SoLuongDU";
            this.txt_SoLuongDU.Size = new System.Drawing.Size(177, 22);
            this.txt_SoLuongDU.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số Lượng";
            // 
            // txt_TenDoUong
            // 
            this.txt_TenDoUong.Location = new System.Drawing.Point(566, 191);
            this.txt_TenDoUong.Name = "txt_TenDoUong";
            this.txt_TenDoUong.Size = new System.Drawing.Size(177, 22);
            this.txt_TenDoUong.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên Đồ Uống";
            // 
            // txt_MaDoUong
            // 
            this.txt_MaDoUong.Location = new System.Drawing.Point(566, 152);
            this.txt_MaDoUong.Name = "txt_MaDoUong";
            this.txt_MaDoUong.Size = new System.Drawing.Size(177, 22);
            this.txt_MaDoUong.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã Đồ Uống";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(731, 555);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 37);
            this.btn_Close.TabIndex = 22;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(634, 268);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(93, 33);
            this.btn_Load.TabIndex = 23;
            this.btn_Load.Text = "LoadGrid";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(119, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "STT";
            // 
            // txt_STT
            // 
            this.txt_STT.Location = new System.Drawing.Point(227, 111);
            this.txt_STT.Name = "txt_STT";
            this.txt_STT.Size = new System.Drawing.Size(177, 22);
            this.txt_STT.TabIndex = 25;
            // 
            // txt_MaBan
            // 
            this.txt_MaBan.Location = new System.Drawing.Point(566, 111);
            this.txt_MaBan.Name = "txt_MaBan";
            this.txt_MaBan.Size = new System.Drawing.Size(177, 22);
            this.txt_MaBan.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mã Bàn";
            // 
            // frm_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(914, 628);
            this.Controls.Add(this.txt_MaBan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_STT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_SoLuongDU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenDoUong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_MaDoUong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_SoLuongMonAn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TenMonAn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_XoaB);
            this.Controls.Add(this.btn_SuaB);
            this.Controls.Add(this.btn_ThemB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.txt_MaMonAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Ban);
            this.Name = "frm_Ban";
            this.Text = "Ban";
            this.Load += new System.EventHandler(this.frm_Ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cb_Ban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_MaMonAn;
        public System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_ThemB;
        public System.Windows.Forms.Button btn_SuaB;
        public System.Windows.Forms.Button btn_XoaB;
        public System.Windows.Forms.TextBox txt_TenMonAn;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_SoLuongMonAn;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_SoLuongDU;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_TenDoUong;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_MaDoUong;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_STT;
        public System.Windows.Forms.TextBox txt_MaBan;
        private System.Windows.Forms.Label label10;
    }
}