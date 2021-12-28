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
    public partial class phancongday : Form
    {
        Nhanvien nhanvien = new Nhanvien();
        Process x = new Process();
        public phancongday()
        {
            InitializeComponent();

            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvien.lay_pc(cbto.Text, cbkyhoc.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvien.lay_pc(cbto.Text, cbkyhoc.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phangiangday phangiangday = new Phangiangday(cbto.Text,cbkyhoc.Text);
            phangiangday.ShowDialog();
        }
        private void load()
        {
            DataTable data = x.lay_hocky();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbkyhoc.Items.Add(data.Rows[i][0]);
            }
            if (data.Rows.Count == 0)
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

            data = nhanvien.lay_tobomon();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbto.Items.Add(data.Rows[i][0]);
            }
            cbto.Text = cbto.Items[0].ToString();

        }
    }
}
