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
    public partial class Formquanhe_giadinh : Form
    {
        Process x = new Process();
        Hocsinh hocsinh = new Hocsinh();
        string matk;
        public Formquanhe_giadinh(string matk)
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
            tbtenbo.Enabled = tbtenme.Enabled = tbtengh.Enabled = on_off;
            nnb.Enabled = nngh.Enabled = nnm.Enabled = on_off;
            dtb.Enabled = dtgh.Enabled = dtm.Enabled = on_off;
            qtb.Enabled = qtgh.Enabled = qtm.Enabled = on_off;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            on_off_textbox(false);
            button3.Enabled = false;
            button1.Enabled = true;
            x.Sua_giadinh_bo(matk, tbtenbo.Text, dtb.Text, qtb.Text, nnb.Text);
            x.Sua_giadinh_me(matk, tbtenme.Text, dtm.Text, qtm.Text, nnm.Text);
            x.Sua_giadinh_gh(matk, tbtengh.Text, dtgh.Text, qtgh.Text, nngh.Text);
            MessageBox.Show("Sửa thành công", "Thông báo");
            load();
        }
        private void load()
        {
            DataTable data = hocsinh.lay_tt_giadinh(matk);
            if (data.Rows.Count == 0)
            {
                tbtenbo.Text = "";
                qtb.Text = "";
                dtb.Text = "";
                nnb.Text = "";

                tbtenme.Text = "";
                qtm.Text = "";
                dtm.Text = "";
                nnm.Text = "";

                tbtengh.Text = "";
                qtgh.Text = "";
                dtgh.Text = "";
                nngh.Text = "";
            }
            else
            {
                tbtenbo.Text = data.Rows[0][1].ToString();
                qtb.Text = data.Rows[0][2].ToString();
                dtb.Text = data.Rows[0][3].ToString();
                nnb.Text = data.Rows[0][4].ToString();

                tbtenme.Text = data.Rows[0][5].ToString();
                qtm.Text = data.Rows[0][6].ToString();
                dtm.Text = data.Rows[0][7].ToString();
                nnm.Text = data.Rows[0][8].ToString();

                tbtengh.Text = data.Rows[0][9].ToString();
                qtgh.Text = data.Rows[0][10].ToString();
                dtgh.Text = data.Rows[0][11].ToString();
                nngh.Text = data.Rows[0][12].ToString();
            }
        }
    }
}
