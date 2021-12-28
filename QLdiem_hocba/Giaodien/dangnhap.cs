using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLdiem_hocba
{
    public partial class dangnhap : Form
    {
        Process Process = new Process();
        public dangnhap()
        {
            InitializeComponent();
            tbpass.PasswordChar = '*';
            DateTime now = DateTime.Now;
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            DataTable dataTable = Process.lay_loai_tk(tbname.Text);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Tên tài khoản không đúng", "Thông Báo");
            } else if (tbname.Text.Contains(" "))
            {
                MessageBox.Show("Tên tài khoản không được có ký tự space", "Thông Báo");
            }
            else if (tbpass.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được có ký tự space", "Thông Báo");
            }
            else if (tbname.Text.Length < 5) {
                MessageBox.Show("Tên tài khoản phải có ít nhất 5 ký tự", "Thông Báo");
            }
            else if (tbpass.Text.Length < 6 || tbpass.Text.Length >= 15)
            {
                MessageBox.Show("Mật khẩu phải có từ 6 - 15 ký tự", "Thông Báo");
            }
            else
            {
                if(Equals(dataTable.Rows[0][1].ToString(), tbpass.Text))
                {
                    string ma = dataTable.Rows[0][0].ToString();
                    if (Equals(dataTable.Rows[0][2].ToString(), "HS"))
                    {
                        giaodien_hocsinh giaodien_Hocsinh = new giaodien_hocsinh(ma);
                        this.Hide();
                        giaodien_Hocsinh.ShowDialog();
                        reset_form();
                        this.Show();
                    }
                    else if (Equals(dataTable.Rows[0][2].ToString(), "GV"))
                    {
                        giaodien_giaovien giaodien_Giaovien = new giaodien_giaovien(ma);
                        this.Hide();
                        giaodien_Giaovien.ShowDialog();
                        reset_form();
                        this.Show();
                    }
                    else if (Equals(dataTable.Rows[0][2].ToString(), "NV"))
                    {
                        giaodien_nhanvien giaodien_Nhanvien = new giaodien_nhanvien(ma);
                        this.Hide();
                        giaodien_Nhanvien.ShowDialog();
                        reset_form();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("sai mk");
                }
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void reset_form()
        {
            tbname.Text = tbpass.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
