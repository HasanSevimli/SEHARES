using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp2_proje
{
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            anasayfa form1gecis = new anasayfa();
            form1gecis.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rezervasyon_duzenle_Click(object sender, EventArgs e)
        {
            rezervasyon form6gecis = new rezervasyon();
            form6gecis.Show();
            this.Hide();
        }

        private void siparis_duzenle_Click(object sender, EventArgs e)
        {
            masa_siparis form3gecis = new masa_siparis();
            form3gecis.Show();
            this.Hide();
        }
    }
}
