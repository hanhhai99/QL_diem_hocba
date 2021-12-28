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
    public partial class Themlop : Form
    {
        Process x = new Process();
        Nhanvien nhanvien = new Nhanvien();
        string magv="";
        public Themlop()
        {
            InitializeComponent();
            dataGridView1.DataSource = nhanvien.lay_gv();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            magv = dataGridView1.Rows[index].Cells[0].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(" ") )
            {
                MessageBox.Show("Mã không được có ký tự space", "Thông Báo");
            }
            else if(Equals(magv, ""))
            {
                MessageBox.Show("hãy chọn 1 giáo viên chủ nhiệm", "Thông Báo");
            }
            else if (Equals(textBox1.Text, "") || Equals(textBox2.Text, ""))
            {
                MessageBox.Show("nhập đầy đủ thông tin", "Thông Báo");
            }
            else
            {
                if (nhanvien.check_lop(textBox1.Text,int.Parse(textBox2.Text)))
                {
                    nhanvien.Tao_lop(textBox1.Text, int.Parse(textBox2.Text), magv);
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Lớp đã tồn tại", "Thông Báo");
                }
            }
        }
    }
}
