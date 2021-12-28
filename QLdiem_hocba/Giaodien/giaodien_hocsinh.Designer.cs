namespace QLdiem_hocba
{
    partial class giaodien_hocsinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giaodien_hocsinh));
            this.bt_gt = new System.Windows.Forms.Button();
            this.bt_syll = new System.Windows.Forms.Button();
            this.bt_diemht = new System.Windows.Forms.Button();
            this.bt_timngdung = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_gt
            // 
            this.bt_gt.Location = new System.Drawing.Point(324, 12);
            this.bt_gt.Name = "bt_gt";
            this.bt_gt.Size = new System.Drawing.Size(118, 42);
            this.bt_gt.TabIndex = 0;
            this.bt_gt.Text = "GIỚI THIỆU";
            this.bt_gt.UseVisualStyleBackColor = true;
            this.bt_gt.Click += new System.EventHandler(this.bt_gt_Click);
            // 
            // bt_syll
            // 
            this.bt_syll.Location = new System.Drawing.Point(475, 12);
            this.bt_syll.Name = "bt_syll";
            this.bt_syll.Size = new System.Drawing.Size(118, 42);
            this.bt_syll.TabIndex = 1;
            this.bt_syll.Text = "SƠ YẾU LÝ LỊCH";
            this.bt_syll.UseVisualStyleBackColor = true;
            this.bt_syll.Click += new System.EventHandler(this.bt_syll_Click);
            // 
            // bt_diemht
            // 
            this.bt_diemht.Location = new System.Drawing.Point(631, 12);
            this.bt_diemht.Name = "bt_diemht";
            this.bt_diemht.Size = new System.Drawing.Size(118, 42);
            this.bt_diemht.TabIndex = 2;
            this.bt_diemht.Text = "ĐIỂM HỌC TẬP";
            this.bt_diemht.UseVisualStyleBackColor = true;
            this.bt_diemht.Click += new System.EventHandler(this.bt_diemht_Click);
            // 
            // bt_timngdung
            // 
            this.bt_timngdung.Location = new System.Drawing.Point(386, 96);
            this.bt_timngdung.Name = "bt_timngdung";
            this.bt_timngdung.Size = new System.Drawing.Size(118, 42);
            this.bt_timngdung.TabIndex = 3;
            this.bt_timngdung.Text = "TÌM NGƯỜI DÙNG";
            this.bt_timngdung.UseVisualStyleBackColor = true;
            this.bt_timngdung.Click += new System.EventHandler(this.bt_timngdung_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(552, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 42);
            this.button6.TabIndex = 17;
            this.button6.Text = "ĐĂNG XUẤT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(193, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã học sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên học sinh";
            // 
            // giaodien_hocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bt_timngdung);
            this.Controls.Add(this.bt_diemht);
            this.Controls.Add(this.bt_syll);
            this.Controls.Add(this.bt_gt);
            this.Name = "giaodien_hocsinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỌC SINH";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_gt;
        private System.Windows.Forms.Button bt_syll;
        private System.Windows.Forms.Button bt_diemht;
        private System.Windows.Forms.Button bt_timngdung;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}