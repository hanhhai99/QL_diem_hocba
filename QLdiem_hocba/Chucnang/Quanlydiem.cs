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

namespace QLdiem_hocba.Chucnang
{
    public partial class Quanlydiem : Form
    {
        Process x = new Process();
        Giaovien giaovien = new Giaovien();
        public Quanlydiem()
        {
            InitializeComponent();
            load();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            string ma_hs = dataGridView2.Rows[index].Cells[0].Value.ToString();
            suadiemloi suadiemloi = new suadiemloi(ma_hs, cbmon.Text, cbkyhoc.Text);
            suadiemloi.ShowDialog();
            dataGridView2.DataSource= x.tim_hs_mon(cbmon.Text, cbkyhoc.Text, cblop.Text);
        }

        private void cbkyhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = x.tim_hs_mon(cbmon.Text, cbkyhoc.Text, cblop.Text);
        }
        private void load()
        {
            cblop.Items.Clear();
            cbkyhoc.Items.Clear();
            cbmon.Items.Clear();
            int year = DateTime.Now.Year;
            if(DateTime.Now.Month < 7)
            {
                year--;
            }
            DataTable data = x.lay_lop(year);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cblop.Items.Add(data.Rows[i][0]);
            }
            if (cblop.Items.Count==0)
            {
                MessageBox.Show("Chưa có lớp được tạo", "Thông báo");
            }
            else
            {
                cblop.Text = cblop.Items[0].ToString();
            }
            //
            data = x.tim_mon(); ;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbmon.Items.Add(data.Rows[i][0]);
            }
            if (cbmon.Items.Count == 0)
            {
                MessageBox.Show("Chưa có môn được tạo", "Thông báo");
            }
            else
            {
                cbmon.Text = cbmon.Items[0].ToString();
            }
            
            //
            data = x.lay_hocky();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbkyhoc.Items.Add(data.Rows[i][0]);
            }
            if (data.Rows.Count==0)
            {
                if (DateTime.Now.Month < 7)
                {
                    cbkyhoc.Items.Add("kỳ 2" + " năm " + (DateTime.Now.Year - 1));
                }
                else
                {
                    cbkyhoc.Items.Add("kỳ 1" + " năm " + DateTime.Now.Year);
                }
            }
            cbkyhoc.Text = cbkyhoc.Items[0].ToString();
            dataGridView2.DataSource = x.tim_hs_mon(cbmon.Text, cbkyhoc.Text, cblop.Text);
        }

        private void cbmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = x.tim_hs_mon(cbmon.Text, cbkyhoc.Text, cblop.Text);
        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = x.tim_hs_mon(cbmon.Text, cbkyhoc.Text, cblop.Text);
        }
    }
}
