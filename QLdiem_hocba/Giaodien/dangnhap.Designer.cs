namespace QLdiem_hocba
{
    partial class dangnhap
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(164, 134);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 0;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(164, 170);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 1;
            this.tbpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Location = new System.Drawing.Point(164, 236);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.bt_dangnhap.TabIndex = 2;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hệ thống quản lí điểm học bạ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(406, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbname);
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

