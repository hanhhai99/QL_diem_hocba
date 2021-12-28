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
    public partial class Formthongtin_canhan : Form
    {
        Process x = new Process();
        Hocsinh hocsinh = new Hocsinh();
        string matk;
        public Formthongtin_canhan(string matk)
        {
            this.matk = matk;
            InitializeComponent();

            load();

            on_off_textbox(false);
            button1.Enabled = true;
            button3.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            on_off_textbox(true);
            button3.Enabled = true;
            button1.Enabled = false;
        }
        private void on_off_textbox(bool on_off)
        {
            tbchohientai.Enabled = tbcmnd.Enabled = tbdantoc.Enabled = on_off;
            tbdktt.Enabled = tbgioitinh.Enabled = tbhoten.Enabled = on_off;
            tbma.Enabled = tbngaysinh.Enabled = tbnoisinh.Enabled = on_off;
            tbquequan.Enabled = tbquoctich.Enabled = on_off;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            on_off_textbox(false);
            button3.Enabled = false;
            button1.Enabled = true;
            x.Sua_soyeulylich(matk, tbdantoc.Text, tbcmnd.Text, tbdktt.Text, tbchohientai.Text);
            MessageBox.Show("Sửa thành công", "Thông báo");
            load();
        }
        private void load()
        {
            DataTable data = hocsinh.lay_tt_canhan(matk);
            if (data.Rows.Count == 0)
            {
                tbnoisinh.Text = "";
                tbquequan.Text = "";
                tbdantoc.Text = "";
                tbquoctich.Text = "";
                tbcmnd.Text = "";
                tbdktt.Text = "";
                tbchohientai.Text = "";
            }
            else
            {
                tbnoisinh.Text = data.Rows[0][1].ToString();
                tbquequan.Text = data.Rows[0][2].ToString();
                tbdantoc.Text = data.Rows[0][3].ToString();
                tbquoctich.Text = data.Rows[0][4].ToString();
                tbcmnd.Text = data.Rows[0][5].ToString();
                tbdktt.Text = data.Rows[0][6].ToString();
                tbchohientai.Text = data.Rows[0][7].ToString();
            }

            data = hocsinh.lay_tt_gioithieu(matk);
            tbma.Text = matk;
            tbhoten.Text = data.Rows[0][0].ToString();
            tbngaysinh.Text = data.Rows[0][1].ToString().Substring(0, 10);
            tbgioitinh.Text = data.Rows[0][2].ToString();
        }
    }
}
