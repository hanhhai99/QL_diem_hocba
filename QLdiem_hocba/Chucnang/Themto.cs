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
    public partial class Themto : Form
    {
        Nhanvien Nhanvien = new Nhanvien();
        public Themto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Equals(textBox1.Text,"") || Equals(textBox2.Text, ""))
            {
                MessageBox.Show("Hãy điền đủ thông tin", "Thông Báo");
            }
            else if (textBox1.Text.Contains(" "))
            {
                MessageBox.Show("Mã không được có ký tự space", "Thông Báo");
            }
            else 
            {
                if (Nhanvien.check_to(textBox1.Text))
                {
                    Nhanvien.Tao_to(textBox1.Text, textBox2.Text);
                    MessageBox.Show("Tạo thành công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Tổ đã tồn tại", "Thông Báo");
                }
            }
        }
    }
}
