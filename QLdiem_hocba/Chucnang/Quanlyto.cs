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

namespace QLdiem_hocba.Chucnang
{
    public partial class Quanlyto : Form
    {
        Nhanvien nhanvien = new Nhanvien();
        public Quanlyto()
        {
            InitializeComponent();

            dataGridView1.DataSource = nhanvien.lay_to(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themto themto = new Themto();
            themto.ShowDialog();
            dataGridView1.DataSource = nhanvien.lay_to(1);
        }
    }
}
