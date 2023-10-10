using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TuyenDung
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt vị trí bắt đầu ở giữa màn hình

        }

        public frm_main(string name)
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Xin chào: " + name;
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt vị trí bắt đầu ở giữa màn hình


        }

        private void ứngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ungvien frm = new frm_ungvien();

            // Lấy kích thước của frm_cha
            int chaWidth = this.Width;
            int chaHeight = this.Height;

            // Đặt kích thước của frm_con bằng kích thước của frm_cha
            frm.Size = new Size(chaWidth, chaHeight);

            // Đặt vị trí của frm_con ở giữa của frm_cha
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.Show();
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhanvienn1 frm = new frm_nhanvienn1();

            // Lấy kích thước của frm_cha
            int chaWidth = this.Width;
            int chaHeight = this.Height;

            // Đặt kích thước của frm_con bằng kích thước của frm_cha
            frm.Size = new Size(chaWidth, chaHeight);

            // Đặt vị trí của frm_con ở giữa của frm_cha
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.Show();
        }

        private void việcCầnTuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vieccantuyen frm = new frm_vieccantuyen();

            // Lấy kích thước của frm_cha
            int chaWidth = this.Width;
            int chaHeight = this.Height;

            // Đặt kích thước của frm_con bằng kích thước của frm_cha
            frm.Size = new Size(chaWidth, chaHeight);

            // Đặt vị trí của frm_con ở giữa của frm_cha
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.Show();
        }

        private void côngTyTuyểnDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_congtytuyen frm = new frm_congtytuyen();

            // Lấy kích thước của frm_cha
            int chaWidth = this.Width;
            int chaHeight = this.Height;

            // Đặt kích thước của frm_con bằng kích thước của frm_cha
            frm.Size = new Size(chaWidth, chaHeight);

            // Đặt vị trí của frm_con ở giữa của frm_cha
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_congtytuyen frm = new frm_congtytuyen();
            frm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_nhanvienn1 frm = new frm_nhanvienn1();
            frm.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           frm_ungvien frm = new frm_ungvien();
            frm.ShowDialog(this);
        }
    }
}
