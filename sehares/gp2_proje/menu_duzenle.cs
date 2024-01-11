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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gp2_proje
{
    public partial class menu_duzenle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public menu_duzenle()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            InitializeComponent();
        }
        void menu_getir()
        {


            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT * FROM urun", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_data.DataSource = menutablo;

            baglanti.Close();


        }

        private void menu_data_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            urun_adi_giris.Text = menu_data.CurrentRow.Cells[1].Value.ToString();
            urun_fiyat_giris.Text = menu_data.CurrentRow.Cells[2].Value.ToString();
            urun_id_giris.Text = menu_data.CurrentRow.Cells[0].Value.ToString();
            urun_tipi_giris.Text = menu_data.CurrentRow.Cells[3].Value.ToString();
        }

        private void menu_ekle_Click(object sender, EventArgs e)
        {
            string urunfiyat = urun_fiyat_giris.Text;
            int sayi;
            if (!int.TryParse(urunfiyat, out sayi))
            {

                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                urun_fiyat_giris.Clear();
                return;

            }
            using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True"))
            {
                baglanti.Open();
                string menu_ekle_sorgu = "INSERT INTO urun(urun_adi, urun_fiyat, urun_tipi) VALUES (@ad, @fiyat, @tip)";
                komut = new SqlCommand(menu_ekle_sorgu, baglanti);

                komut.Parameters.AddWithValue("@ad", urun_adi_giris.Text);
                komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(urun_fiyat_giris.Text));
                komut.Parameters.AddWithValue("@tip", urun_tipi_giris.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            menu_getir();
        }

        private void menu_guncelle_Click(object sender, EventArgs e)
        {
            string urunfiyat = urun_fiyat_giris.Text;
            int sayi;
            if (!int.TryParse(urunfiyat, out sayi))
            {

                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                urun_fiyat_giris.Clear();
                return;

            }
            using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True"))
            {
                baglanti.Open();
                string menu_guncelle_sorgu = "UPDATE urun SET urun_adi = @ad, urun_fiyat = @fiyat, urun_tipi = @tip WHERE urunID = @id";
                komut = new SqlCommand(menu_guncelle_sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(urun_id_giris.Text));
                komut.Parameters.AddWithValue("@ad", urun_adi_giris.Text);
                komut.Parameters.AddWithValue("@fiyat", urun_fiyat_giris.Text);
                komut.Parameters.AddWithValue("@tip", urun_tipi_giris.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            menu_getir();
        }

        private void menu_kaldır_Click(object sender, EventArgs e)
        {

            using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True"))
            {
                baglanti.Open();
                string personel_kaldir_sorgu = "DELETE FROM urun WHERE urunID = @id";
                komut = new SqlCommand(personel_kaldir_sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(urun_id_giris.Text));

                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            menu_getir();
        }

        private void menu_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menu_duzenle_Load(object sender, EventArgs e)
        {
            menu_getir();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            menu_ekran menugecis = new menu_ekran();
            menugecis.Show();
            this.Hide();
        }
    }
}
