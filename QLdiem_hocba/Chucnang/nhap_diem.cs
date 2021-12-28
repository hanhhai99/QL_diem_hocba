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

namespace QLdiem_hocba
{
    public partial class nhap_diem : Form
    {
        Process x = new Process();
        Giaovien giaovien = new Giaovien();
        string matk;
        public nhap_diem(string matk)
        {
            this.matk = matk;
            InitializeComponent();
            load();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            string ma_hs = dataGridView2.Rows[index].Cells[0].Value.ToString();
            suadiemloi suadiemloi = new suadiemloi(ma_hs, cbmon.Text, cbkyhoc.Text);
            suadiemloi.ShowDialog();
            dataGridView2.DataSource= giaovien.tim_mon_day(matk, cbmon.Text, cbkyhoc.Text, cblop.Text);
        }

        private void cbkyhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = giaovien.tim_mon_day(matk,cbmon.Text,cbkyhoc.Text, cblop.Text);
        }
        private void load()
        {
            cblop.Items.Clear();
            cbkyhoc.Items.Clear();
            cbmon.Items.Clear();
            DataTable data = giaovien.tim_lop(matk);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cblop.Items.Add(data.Rows[i][1]);
            }
            cblop.Text = cblop.Items[0].ToString();
            //
            data = giaovien.tim_mon(matk);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbmon.Items.Add(data.Rows[i][0].ToString());
            }
            cbmon.Text = cbmon.Items[0].ToString();
            //
            data = x.lay_hocky();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbkyhoc.Items.Add(data.Rows[i][0].ToString());
            }
            cbkyhoc.Text = cbkyhoc.Items[0].ToString();
            dataGridView2.DataSource = giaovien.tim_mon_day(matk, cbmon.Text, cbkyhoc.Text, cblop.Text);
        }

        private void cbmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = giaovien.tim_mon_day(matk, cbmon.Text, cbkyhoc.Text, cblop.Text);
        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = giaovien.tim_mon_day(matk, cbmon.Text, cbkyhoc.Text, cblop.Text);
        }
    }
}
