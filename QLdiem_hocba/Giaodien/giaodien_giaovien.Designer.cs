namespace QLdiem_hocba
{
    partial class giaodien_giaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giaodien_giaovien));
            this.bt_xemloi = new System.Windows.Forms.Button();
            this.bt_timngdung = new System.Windows.Forms.Button();
            this.bt_diem = new System.Windows.Forms.Button();
            this.bt_lopday = new System.Windows.Forms.Button();
            this.bt_gt = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_xemloi
            // 
            this.bt_xemloi.Location = new System.Drawing.Point(392, 67);
            this.bt_xemloi.Name = "bt_xemloi";
            this.bt_xemloi.Size = new System.Drawing.Size(118, 42);
            this.bt_xemloi.TabIndex = 12;
            this.bt_xemloi.Text = "Ý KIẾN CỦA HỌC SINH";
            this.bt_xemloi.UseVisualStyleBackColor = true;
            this.bt_xemloi.Click += new System.EventHandler(this.bt_xemloi_Click);
            // 
            // bt_timngdung
            // 
            this.bt_timngdung.Location = new System.Drawing.Point(258, 67);
            this.bt_timngdung.Name = "bt_timngdung";
            this.bt_timngdung.Size = new System.Drawing.Size(118, 42);
            this.bt_timngdung.TabIndex = 11;
            this.bt_timngdung.Text = "TÌM NGƯỜI DÙNG";
            this.bt_timngdung.UseVisualStyleBackColor = true;
            this.bt_timngdung.Click += new System.EventHandler(this.bt_timngdung_Click);
            // 
            // bt_diem
            // 
            this.bt_diem.Location = new System.Drawing.Point(516, 12);
            this.bt_diem.Name = "bt_diem";
            this.bt_diem.Size = new System.Drawing.Size(118, 42);
            this.bt_diem.TabIndex = 10;
            this.bt_diem.Text = "NHẬP ĐIỂM / ĐÁNH GIÁ";
            this.bt_diem.UseVisualStyleBackColor = true;
            this.bt_diem.Click += new System.EventHandler(this.bt_diem_Click);
            // 
            // bt_lopday
            // 
            this.bt_lopday.Location = new System.Drawing.Point(392, 12);
            this.bt_lopday.Name = "bt_lopday";
            this.bt_lopday.Size = new System.Drawing.Size(118, 42);
            this.bt_lopday.TabIndex = 9;
            this.bt_lopday.Text = "LỚP GIẢNG DẠY";
            this.bt_lopday.UseVisualStyleBackColor = true;
            this.bt_lopday.Click += new System.EventHandler(this.bt_lopday_Click);
            // 
            // bt_gt
            // 
            this.bt_gt.Location = new System.Drawing.Point(258, 12);
            this.bt_gt.Name = "bt_gt";
            this.bt_gt.Size = new System.Drawing.Size(118, 42);
            this.bt_gt.TabIndex = 8;
            this.bt_gt.Text = "GIỚI THIỆU";
            this.bt_gt.UseVisualStyleBackColor = true;
            this.bt_gt.Click += new System.EventHandler(this.bt_gt_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(516, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 42);
            this.button6.TabIndex = 16;
            this.button6.Text = "ĐĂNG XUẤT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(136, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // giaodien_giaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bt_xemloi);
            this.Controls.Add(this.bt_timngdung);
            this.Controls.Add(this.bt_diem);
            this.Controls.Add(this.bt_lopday);
            this.Controls.Add(this.bt_gt);
            this.Name = "giaodien_giaovien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIÁO VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_xemloi;
        private System.Windows.Forms.Button bt_timngdung;
        private System.Windows.Forms.Button bt_diem;
        private System.Windows.Forms.Button bt_lopday;
        private System.Windows.Forms.Button bt_gt;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}