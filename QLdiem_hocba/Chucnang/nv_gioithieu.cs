using QLdiem_hocba.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLdiem_hocba.Chucnang
{
    public partial class nv_gioithieu : Form
    {
        Giaovien giaovien = new Giaovien();
        Process x = new Process();
        string matk;
        public nv_gioithieu(string matk,bool sua)
        {
            this.matk = matk;
            InitializeComponent();
            button1.Enabled = sua;
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                tbhoten.Enabled = tbnamsinh.Enabled = tbgioitinh.Enabled = true;
                tbemail.Enabled = tbsdt.Enabled = tbphanloai.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            if (DateTime.TryParse(tbnamsinh.Text, out date) && isValidEmail(tbemail.Text))
            {
                x.Sua_thongtin(matk, tbhoten.Text, DateTime.Parse(tbnamsinh.Text), tbgioitinh.Text, tbemail.Text, tbsdt.Text);
                tbhoten.Enabled = tbnamsinh.Enabled = tbgioitinh.Enabled = false;
                tbemail.Enabled = tbsdt.Enabled = tbphanloai.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
                load();
            }
            else if (!DateTime.TryParse(tbnamsinh.Text, out date))
            {
                MessageBox.Show("Ngày sinh nhập không đúng định dạng", "Thông Báo");
                load();
            }
            else if (!isValidEmail(tbemail.Text))
            {
                MessageBox.Show("Email nhập không đúng định dạng", "Thông Báo");
                load();
            }
        }
        private void load()
        {
            tbhoten.Enabled = tbnamsinh.Enabled = tbgioitinh.Enabled = false;
            tbemail.Enabled = tbsdt.Enabled = tbphanloai.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;

            DataTable data = giaovien.lay_tt_gioithieu(matk);

            tbhoten.Text = data.Rows[0][0].ToString();
            tbnamsinh.Text = data.Rows[0][1].ToString().Substring(0, 10);
            tbgioitinh.Text = data.Rows[0][2].ToString();
            tbemail.Text = data.Rows[0][3].ToString();
            tbsdt.Text = data.Rows[0][4].ToString();
            if (Equals(data.Rows[0][5].ToString(), "GV"))
            {
                tbphanloai.Text = "Giáo Viên - Tổ " + giaovien.lay_tobomon(matk);
            }
            else if (Equals(data.Rows[0][5].ToString(), "NV"))
            {
                tbphanloai.Text = "Nhân Viên";
            }
        }
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

    }
}
