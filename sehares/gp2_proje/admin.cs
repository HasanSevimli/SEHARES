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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu_ekran menugecis = new menu_ekran();
            menugecis.Show();
            this.Hide();
        }

        private void admin_cikis_Click(object sender, EventArgs e)
        {
            anasayfa form1gecis = new anasayfa();
            form1gecis.Show();
            this.Hide();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personel_Click(object sender, EventArgs e)
        {
            personel_liste_form form7gecis = new personel_liste_form();
            form7gecis.Show();
            this.Hide();
        }

        private void ciro_giris_Click(object sender, EventArgs e)
        {
            ciro cirogecis = new ciro();
            cirogecis.Show();
            this.Hide();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
