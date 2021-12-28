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
using QLdiem_hocba.Chucnang;

namespace QLdiem_hocba
{
    public partial class quanly_tk : Form
    {
        Nhanvien nhanvien = new Nhanvien();
        string matk;
        public quanly_tk(string matk)
        {
            this.matk = matk;
            InitializeComponent();

            load();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvien.lay_tk("HS");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvien.lay_tk("GV");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvien.lay_tk("NV");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string ma_ngdung = dataGridView1.Rows[index].Cells[0].Value.ToString();
            if (Equals(ma_ngdung.Substring(0, 2), "HS"))
            {
                gioithieu gioithieu = new gioithieu(ma_ngdung, false);
                gioithieu.ShowDialog();
            }
            else
            {
                nv_gioithieu gioithieu = new nv_gioithieu(ma_ngdung, false);
                gioithieu.ShowDialog();
            }
            if (radioButton1.Checked)
            {
                dataGridView1.DataSource= nhanvien.lay_tk("HS");
            }
            else if (radioButton2.Checked)
            {
                dataGridView1.DataSource = nhanvien.lay_tk("GV");
            }
            else if (radioButton3.Checked)
            {
                dataGridView1.DataSource = nhanvien.lay_tk("NV");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Themtk themtk = new Themtk();
                themtk.ShowDialog();
            }else if (radioButton2.Checked)
            {
                Themgv themgv = new Themgv();
                themgv.ShowDialog();
            }else if (radioButton3.Checked)
            {
                Themnv themnv = new Themnv();
                themnv.ShowDialog();
            }
            load();
        }
        private void load()
        {
            radioButton1.Text = "HỌC SINH : " + nhanvien.lay_sltk("HS");
            radioButton2.Text = "GIÁO VIÊN : " + nhanvien.lay_sltk("GV");
            radioButton3.Text = "NHÂN VIÊN : " + nhanvien.lay_sltk("NV");
            int tong = int.Parse(nhanvien.lay_sltk("HS")) + int.Parse(nhanvien.lay_sltk("NV")) + int.Parse(nhanvien.lay_sltk("GV"));
            lbtong.Text = "TỔNG SỐ TÀI KHOẢN : " + tong;

            if (radioButton1.Checked)
            {
                dataGridView1.DataSource = nhanvien.lay_tk("HS");
            }
            else if (radioButton2.Checked)
            {
                dataGridView1.DataSource = nhanvien.lay_tk("GV");
            }
            else if (radioButton3.Checked)
            {
                dataGridView1.DataSource = nhanvien.lay_tk("NV");
            }
        }
    }
}
