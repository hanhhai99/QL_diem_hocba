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
    public partial class giaodien_hocsinh : Form
    {
        Process x = new Process();
        string matk;
        public giaodien_hocsinh(string matk)
        {
            this.matk = matk;

            InitializeComponent();

            gioithieu gioithieu = new gioithieu(matk,true);
            gioithieu.TopLevel = false;
            panel1.Controls.Add(gioithieu);
            gioithieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gioithieu.Show();

            label1.Text = matk;
            label2.Text = x.lay_ten_ngdung(matk);
        }

        private void bt_syll_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            soyeulylich soyeulylich = new soyeulylich(matk);
            soyeulylich.TopLevel = false;
            panel1.Controls.Add(soyeulylich);
            soyeulylich.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            soyeulylich.Show();
        }

        private void bt_gt_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            gioithieu gioithieu = new gioithieu(matk,true);
            gioithieu.TopLevel = false;
            panel1.Controls.Add(gioithieu);
            gioithieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gioithieu.Show();
        }

        private void bt_diemht_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            xemdiem xemdiem = new xemdiem(matk);
            xemdiem.TopLevel = false;
            panel1.Controls.Add(xemdiem);
            xemdiem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            xemdiem.Show();
        }

        private void bt_timngdung_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            tim_nguoidung tim_Nguoidung = new tim_nguoidung(matk);
            tim_Nguoidung.TopLevel = false;
            panel1.Controls.Add(tim_Nguoidung);
            tim_Nguoidung.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tim_Nguoidung.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
