using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp2_proje
{
    public partial class menu_ekran : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        public menu_ekran()
        {
            InitializeComponent();
        }
        void menu_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT * FROM urun", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu.DataSource = menutablo;

            baglanti.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            menu_getir();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            admin form10gecis = new admin();
            form10gecis.Show();
            this.Hide();
        }

        private void menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_duzenle menuduzenlegecis = new menu_duzenle();
            menuduzenlegecis.Show();
            this.Hide();
        }
    }
}
