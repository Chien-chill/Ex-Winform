namespace BaiKiemTraSo3_Tran_Cong_Dong_21203100059
{
    partial class Bai3_SQL
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
            this.dtgSV = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBoSung = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSV
            // 
            this.dtgSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.tensv,
            this.khoa,
            this.quequan});
            this.dtgSV.Location = new System.Drawing.Point(96, 86);
            this.dtgSV.Name = "dtgSV";
            this.dtgSV.RowHeadersWidth = 62;
            this.dtgSV.RowTemplate.Height = 28;
            this.dtgSV.Size = new System.Drawing.Size(890, 434);
            this.dtgSV.TabIndex = 0;
            this.dtgSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSV_CellClick);
            // 
            // masv
            // 
            this.masv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "Mã Sinh Viên";
            this.masv.MinimumWidth = 8;
            this.masv.Name = "masv";
            this.masv.Width = 139;
            // 
            // tensv
            // 
            this.tensv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tensv.DataPropertyName = "tensv";
            this.tensv.HeaderText = "Tên Sinh Viên";
            this.tensv.MinimumWidth = 8;
            this.tensv.Name = "tensv";
            this.tensv.Width = 144;
            // 
            // khoa
            // 
            this.khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.khoa.DataPropertyName = "khoa";
            this.khoa.HeaderText = "Khoa";
            this.khoa.MinimumWidth = 8;
            this.khoa.Name = "khoa";
            this.khoa.Width = 82;
            // 
            // quequan
            // 
            this.quequan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quequan.DataPropertyName = "quequan";
            this.quequan.HeaderText = "Quê Quán";
            this.quequan.MinimumWidth = 8;
            this.quequan.Name = "quequan";
            this.quequan.Width = 118;
            // 
            // btnBoSung
            // 
            this.btnBoSung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoSung.Location = new System.Drawing.Point(200, 541);
            this.btnBoSung.Name = "btnBoSung";
            this.btnBoSung.Size = new System.Drawing.Size(158, 40);
            this.btnBoSung.TabIndex = 1;
            this.btnBoSung.Text = "Bổ Sung";
            this.btnBoSung.UseVisualStyleBackColor = true;
            this.btnBoSung.Click += new System.EventHandler(this.btnBoSung_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(727, 541);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(158, 40);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(382, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Sinh Viên";
            // 
            // Bai3_SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnBoSung);
            this.Controls.Add(this.dtgSV);
            this.Name = "Bai3_SQL";
            this.Text = "Bai3_SQL";
            this.Load += new System.EventHandler(this.Bai3_SQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.Button btnBoSung;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dtgSV;
    }
}