using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLdiem_hocba.Class;

namespace QLdiem_hocba.Chucnang
{
    public partial class Themmon : Form
    {
        Nhanvien nhanvien = new Nhanvien();
        public Themmon()
        {
            InitializeComponent();
            DataTable data = nhanvien.lay_tobomon();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                comboBox1.Items.Add(data.Rows[i][0].ToString());
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nhanvien.Them_mon(textBox2.Text, textBox4.Text, int.Parse(textBox3.Text), comboBox1.Text);
            MessageBox.Show("Tạo thành công", "Thông Báo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
