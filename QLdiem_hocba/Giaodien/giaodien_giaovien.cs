using QLdiem_hocba.Chucnang;
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
    public partial class giaodien_giaovien : Form
    {
        string matk;
        public giaodien_giaovien(string matk)
        {
            this.matk = matk;
            InitializeComponent();

            nv_gioithieu gioithieu = new nv_gioithieu(matk,true);
            gioithieu.TopLevel = false;
            panel1.Controls.Add(gioithieu);
            gioithieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gioithieu.Show();
        }

        private void bt_gt_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            nv_gioithieu gioithieu = new nv_gioithieu(matk,true);
            gioithieu.TopLevel = false;
            panel1.Controls.Add(gioithieu);
            gioithieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gioithieu.Show();
        }

        private void bt_lopday_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            lop_giangday lop_giangday = new lop_giangday(matk);
            lop_giangday.TopLevel = false;
            panel1.Controls.Add(lop_giangday);
            lop_giangday.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lop_giangday.Show();
        }

        private void bt_diem_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            nhap_diem nhapdiem = new nhap_diem(matk);
            nhapdiem.TopLevel = false;
            panel1.Controls.Add(nhapdiem);
            nhapdiem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            nhapdiem.Show();
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

        private void bt_xemloi_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            xembaocaoloi xembaocaoloi = new xembaocaoloi(matk);
            xembaocaoloi.TopLevel = false;
            panel1.Controls.Add(xembaocaoloi);
            xembaocaoloi.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            xembaocaoloi.Show();
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
    }
}
