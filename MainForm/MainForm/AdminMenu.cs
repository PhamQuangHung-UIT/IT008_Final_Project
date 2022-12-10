using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button_AdminNV_Click(object sender, EventArgs e)
        {
            panel_AdminNhanVien.Visible = true;
            panel_AdminDichVu.Visible = false;
            panel_AdminBan.Visible = false;
        }

        private void button_AdminDV_Click(object sender, EventArgs e)
        {
            panel_AdminNhanVien.Visible = false;
            panel_AdminDichVu.Visible = true;
            panel_AdminBan.Visible = false;
        }

        private void button_AdminBan_Click(object sender, EventArgs e)
        {
            panel_AdminNhanVien.Visible = false;
            panel_AdminDichVu.Visible = false;
            panel_AdminBan.Visible = true;
        }

        private void button_AdminThongKe_Click(object sender, EventArgs e)
        {

        }

        private void button_AdminBack_Click(object sender, EventArgs e)
        {
            FMain f1 = new FMain();
            f1.Show();
            this.Close();
        }
    }
}
