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
    public partial class soyeulylich : Form
    {
        string matk;
        public soyeulylich(string matk)
        {
            this.matk = matk;

            InitializeComponent();

            Formthongtin_canhan formthongtin_Canhan = new Formthongtin_canhan(matk);
            formthongtin_Canhan.TopLevel = false;
            tabControl1.TabPages[0].Controls.Add(formthongtin_Canhan);
            formthongtin_Canhan.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formthongtin_Canhan.Show();

            Formquanhe_giadinh formquanhe_Giadinh = new Formquanhe_giadinh(matk);
            formquanhe_Giadinh.TopLevel = false;
            tabControl1.TabPages[1].Controls.Add(formquanhe_Giadinh);
            formquanhe_Giadinh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formquanhe_Giadinh.Show();
        }

        
    }
}
