namespace QLdiem_hocba.Chucnang
{
    partial class Baoloidiem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbmon = new System.Windows.Forms.Label();
            this.lbgv = new System.Windows.Forms.Label();
            this.lb15p = new System.Windows.Forms.Label();
            this.lb1t = new System.Windows.Forms.Label();
            this.lbgiuaky = new System.Windows.Forms.Label();
            this.lbcuoiky = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 93);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NỘI DUNG GỬI:";
            // 
            // lbmon
            // 
            this.lbmon.AutoSize = true;
            this.lbmon.Location = new System.Drawing.Point(73, 13);
            this.lbmon.Name = "lbmon";
            this.lbmon.Size = new System.Drawing.Size(64, 13);
            this.lbmon.TabIndex = 2;
            this.lbmon.Text = "MÔN HỌC :";
            // 
            // lbgv
            // 
            this.lbgv.AutoSize = true;
            this.lbgv.Location = new System.Drawing.Point(281, 13);
            this.lbgv.Name = "lbgv";
            this.lbgv.Size = new System.Drawing.Size(67, 13);
            this.lbgv.TabIndex = 3;
            this.lbgv.Text = "GIÁO VIÊN :";
            // 
            // lb15p
            // 
            this.lb15p.AutoSize = true;
            this.lb15p.Location = new System.Drawing.Point(15, 43);
            this.lb15p.Name = "lb15p";
            this.lb15p.Size = new System.Drawing.Size(54, 13);
            this.lb15p.TabIndex = 4;
            this.lb15p.Text = "Điểm 15\' :";
            // 
            // lb1t
            // 
            this.lb1t.AutoSize = true;
            this.lb1t.Location = new System.Drawing.Point(103, 43);
            this.lb1t.Name = "lb1t";
            this.lb1t.Size = new System.Drawing.Size(76, 13);
            this.lb1t.TabIndex = 5;
            this.lb1t.Text = "ĐIỂM 1 TIẾT :";
            // 
            // lbgiuaky
            // 
            this.lbgiuaky.AutoSize = true;
            this.lbgiuaky.Location = new System.Drawing.Point(224, 43);
            this.lbgiuaky.Name = "lbgiuaky";
            this.lbgiuaky.Size = new System.Drawing.Size(89, 13);
            this.lbgiuaky.TabIndex = 6;
            this.lbgiuaky.Text = "ĐIỂM GIỮA KỲ : ";
            // 
            // lbcuoiky
            // 
            this.lbcuoiky.AutoSize = true;
            this.lbcuoiky.Location = new System.Drawing.Point(369, 43);
            this.lbcuoiky.Name = "lbcuoiky";
            this.lbcuoiky.Size = new System.Drawing.Size(83, 13);
            this.lbcuoiky.TabIndex = 7;
            this.lbcuoiky.Text = "ĐIỂM CUỐI KỲ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "GỬI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Baoloidiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbcuoiky);
            this.Controls.Add(this.lbgiuaky);
            this.Controls.Add(this.lb1t);
            this.Controls.Add(this.lb15p);
            this.Controls.Add(this.lbgv);
            this.Controls.Add(this.lbmon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Baoloidiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA ĐIỂM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmon;
        private System.Windows.Forms.Label lbgv;
        private System.Windows.Forms.Label lb15p;
        private System.Windows.Forms.Label lb1t;
        private System.Windows.Forms.Label lbgiuaky;
        private System.Windows.Forms.Label lbcuoiky;
        private System.Windows.Forms.Button button1;
    }
}