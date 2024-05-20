
namespace QL_NHAHANG
{
    partial class frm_Menu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Loai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ExitM = new System.Windows.Forms.Button();
            this.btn_LoadGrip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // cb_Loai
            // 
            this.cb_Loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Loai.FormattingEnabled = true;
            this.cb_Loai.Location = new System.Drawing.Point(224, 72);
            this.cb_Loai.Name = "cb_Loai";
            this.cb_Loai.Size = new System.Drawing.Size(196, 28);
            this.cb_Loai.TabIndex = 2;
            this.cb_Loai.SelectedIndexChanged += new System.EventHandler(this.cb_Loai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Sản Phẩm";
            // 
            // btn_ExitM
            // 
            this.btn_ExitM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitM.Location = new System.Drawing.Point(631, 403);
            this.btn_ExitM.Name = "btn_ExitM";
            this.btn_ExitM.Size = new System.Drawing.Size(97, 35);
            this.btn_ExitM.TabIndex = 4;
            this.btn_ExitM.Text = "Close";
            this.btn_ExitM.UseVisualStyleBackColor = true;
            this.btn_ExitM.Click += new System.EventHandler(this.btn_ExitM_Click);
            // 
            // btn_LoadGrip
            // 
            this.btn_LoadGrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadGrip.Location = new System.Drawing.Point(537, 68);
            this.btn_LoadGrip.Name = "btn_LoadGrip";
            this.btn_LoadGrip.Size = new System.Drawing.Size(90, 32);
            this.btn_LoadGrip.TabIndex = 33;
            this.btn_LoadGrip.Text = "LoadGrid";
            this.btn_LoadGrip.UseVisualStyleBackColor = true;
            this.btn_LoadGrip.Click += new System.EventHandler(this.btn_LoadGrip_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_LoadGrip);
            this.Controls.Add(this.btn_ExitM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Loai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_Loai;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_ExitM;
        public System.Windows.Forms.Button btn_LoadGrip;
    }
}