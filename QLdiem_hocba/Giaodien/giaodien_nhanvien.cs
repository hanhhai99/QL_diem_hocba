using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLdiem_hocba.Chucnang;

namespace QLdiem_hocba
{
    public partial class giaodien_nhanvien : Form
    {
        string matk;

        public giaodien_nhanvien(string matk)
        {
            this.matk = matk;
            InitializeComponent();

            nv_gioithieu gioithieu = new nv_gioithieu(matk, true);
            gioithieu.TopLevel = false;
            panel1.Controls.Add(gioithieu);
            gioithieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gioithieu.Show();
        }

        private void bt_gt_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            nv_gioithieu gioithieu = new nv_gioithieu(matk, true);
            gioithieu.TopLevel = false;
            panel1.Controls.Add(gioithieu);
            gioithieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gioithieu.Show();
        }

        private void bt_qld_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            Quanlydiem Quanlydiem = new Quanlydiem();
            Quanlydiem.TopLevel = false;
            panel1.Controls.Add(Quanlydiem);
            Quanlydiem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Quanlydiem.Show();
        }
        private void bt_phancong_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            phancongday phancongday = new phancongday();
            phancongday.TopLevel = false;
            panel1.Controls.Add(phancongday);
            phancongday.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            phancongday.Show();
            
        }

        private void bt_qlmon_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            quanlymon quanlymon = new quanlymon();
            quanlymon.TopLevel = false;
            panel1.Controls.Add(quanlymon);
            quanlymon.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            quanlymon.Show();
        }

        private void bt_qltk_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            quanly_tk quanly_tk = new quanly_tk(matk);
            quanly_tk.TopLevel = false;
            panel1.Controls.Add(quanly_tk);
            quanly_tk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            quanly_tk.Show();
        }

        private void bt_hocba_Click(object sender, EventArgs e)
        {
            
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

        private void btqllop_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            Quanlylop quanlylop = new Quanlylop();
            quanlylop.TopLevel = false;
            panel1.Controls.Add(quanlylop);
            quanlylop.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            quanlylop.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.RemoveAt(0);
            Quanlyto Quanlyto = new Quanlyto();
            Quanlyto.TopLevel = false;
            panel1.Controls.Add(Quanlyto);
            Quanlyto.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Quanlyto.Show();
        }
    }
}
