namespace QLdiem_hocba.Chucnang
{
    partial class Quanlydiem
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
            this.cbmon = new System.Windows.Forms.ComboBox();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.cbkyhoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmon
            // 
            this.cbmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmon.FormattingEnabled = true;
            this.cbmon.Location = new System.Drawing.Point(55, 32);
            this.cbmon.Name = "cbmon";
            this.cbmon.Size = new System.Drawing.Size(121, 21);
            this.cbmon.TabIndex = 25;
            this.cbmon.SelectedIndexChanged += new System.EventHandler(this.cbmon_SelectedIndexChanged);
            // 
            // cblop
            // 
            this.cblop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(233, 32);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(121, 21);
            this.cblop.TabIndex = 24;
            this.cblop.SelectedIndexChanged += new System.EventHandler(this.cblop_SelectedIndexChanged);
            // 
            // cbkyhoc
            // 
            this.cbkyhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkyhoc.FormattingEnabled = true;
            this.cbkyhoc.Location = new System.Drawing.Point(406, 32);
            this.cbkyhoc.Name = "cbkyhoc";
            this.cbkyhoc.Size = new System.Drawing.Size(121, 21);
            this.cbkyhoc.TabIndex = 23;
            this.cbkyhoc.SelectedIndexChanged += new System.EventHandler(this.cbkyhoc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "DANH SÁCH HỌC SINH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "LỚP";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(560, 257);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "HỌC KỲ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "MÔN HỌC";
            // 
            // Quanlydiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.cbmon);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.cbkyhoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Quanlydiem";
            this.Text = "Quanlydiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmon;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.ComboBox cbkyhoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}