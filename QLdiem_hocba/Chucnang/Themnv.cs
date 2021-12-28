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
    public partial class Themnv : Form
    {
        Nhanvien nhanvien = new Nhanvien();
        public Themnv()
        {

            InitializeComponent();


            cbgioitinh.Items.Add("Nam");
            cbgioitinh.Items.Add("Nữ");
            cbgioitinh.Text = cbgioitinh.Items[0].ToString();


            for (int i = 1; i <= 31; i++)
                cbngay.Items.Add("" + i);
            cbngay.Text = cbngay.Items[0].ToString();


            cbto.Items.Add("QLD");
            cbto.Text = cbto.Items[0].ToString();

        }
        private void tao_thang(int ngay, ComboBox x)
        {
            if (ngay == 31)
            {
                for (int i = 1; i <= 12; i++)
                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                        x.Items.Add("" + i);
            }
            else if (ngay > 29)
            {
                for (int i = 1; i <= 12; i++)
                    if (i != 2)
                        x.Items.Add("" + i);
            }
            else
            {
                for (int i = 1; i <= 12; i++)
                    x.Items.Add("" + i);
            }

        }
        private void tao_nam(int ngay, int thang, ComboBox x)
        {
            DateTime now = DateTime.Now;

            if (thang == 2 && ngay == 29)
            {
                for (int i = now.Year - 30; i <= now.Year; i++)
                {
                    if (i % 4 == 0 && i % 100 != 0)
                    {
                        x.Items.Add("" + i);
                    }
                }
            }
            else
            {
                for (int i = now.Year - 40; i <= now.Year; i++)
                {
                    x.Items.Add("" + i);
                }
            }
        }

        private void cbngay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbthang.Items.Clear();
            tao_thang(int.Parse(cbngay.Text), cbthang);
            cbthang.Text = cbthang.Items[0].ToString();
        }

        private void cbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbnam.Items.Clear();
            tao_nam(int.Parse(cbngay.Text), int.Parse(cbthang.Text), cbnam);
            cbnam.Text = cbnam.Items[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbma.Text.Contains(" ") || tbmk.Text.Contains(" ") || tbten.Text.Contains(" "))
            {
                MessageBox.Show("Mã / tài khoản / mật khẩu không được có ký tự space", "Thông Báo");
            }
            else if (tbten.Text.Length < 5)
            {
                MessageBox.Show("Tên tài khoản phải có ít nhất 5 ký tự", "Thông Báo");
            }
            else if (tbmk.Text.Length < 6 || tbmk.Text.Length >= 15)
            {
                MessageBox.Show("Mật khẩu phải có từ 6 - 15 ký tự", "Thông Báo");
            }
            else if(nhanvien.kiemtra_mataikhoan(tbma.Text) == 0)
            {
                tbma.Text = tbma.Text.ToUpper();

                int ngay = int.Parse(cbngay.Text);
                int thang = int.Parse(cbthang.Text);
                int nam = int.Parse(cbnam.Text);
                DateTime date = new DateTime(nam, thang, ngay);

                nhanvien.Tao_tk(tbma.Text, tbten.Text, tbmk.Text, "NV",
                                tbtenhs.Text, date, cbgioitinh.Text);
                nhanvien.Tao_nv(tbma.Text, cbto.Text);
                MessageBox.Show("Tạo thành công", "Thông Báo");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
