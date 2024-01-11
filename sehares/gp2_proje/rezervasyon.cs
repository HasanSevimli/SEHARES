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
    public partial class rezervasyon : Form
    {
        SqlConnection baglanti;

        SqlDataAdapter da;
        public rezervasyon()
        {
            InitializeComponent();
        }
        void rezervasyon_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT * FROM rezervasyon", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            rezerv.DataSource = tablo;

            baglanti.Close();

        }
        private void rezervasyon_ekle_Click(object sender, EventArgs e)
        {
            rezervasyadd rezervasyadd = new rezervasyadd();
            rezervasyadd.Show();
            this.Hide();
        }

        private void rezervasyon_Load(object sender, EventArgs e)
        {
            rezervasyon_getir();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void back2_Click(object sender, EventArgs e)
        {
            personel form11gecis = new personel();
            form11gecis.Show();
            this.Hide();
        }
    }
}
