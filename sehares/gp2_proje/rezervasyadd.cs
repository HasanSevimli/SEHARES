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
using static iTextSharp.awt.geom.Point2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gp2_proje
{
    public partial class rezervasyadd : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public rezervasyadd()
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
            rezervasyon_liste.DataSource = tablo;

            baglanti.Close();

        }

        private void rezervasyadd_Load(object sender, EventArgs e)
        {
            rezervasyon_getir();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string masa = masano.SelectedItem as string;
            string isim = ad.Text as string;
            string soyisim = soyad.Text as string;
            string telefonno = telefon.Text as string;



            // odemeTur null mı kontrol etim
            if (string.IsNullOrEmpty(masa))
            {
                // Kullanıcı bir değer seçmediğinde uyarı mesajını göster
                MessageBox.Show("Lütfen bir masa seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Fonksiyonu burada sonlandır, çünkü gerekli bilgi eksik
            }
            else if (string.IsNullOrEmpty(isim))
            {
                // Kullanıcı bir değer seçmediğinde uyarı mesajını göster
                MessageBox.Show("Lütfen İsim Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Fonksiyonu burada sonlandır, çünkü gerekli bilgi eksik
            }
            else if (string.IsNullOrEmpty(soyisim))
            {
                // Kullanıcı bir değer seçmediğinde uyarı mesajını göster
                MessageBox.Show("Lütfen Soyad Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Fonksiyonu burada sonlandır, çünkü gerekli bilgi eksik
            }
            else if (string.IsNullOrEmpty(telefonno))
            {
                // Kullanıcı bir değer seçmediğinde uyarı mesajını göster
                MessageBox.Show("Lütfen Telefon Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Fonksiyonu burada sonlandır, çünkü gerekli bilgi eksik
            }


            string rezervasyon_ekle_sorgu = "INSERT INTO rezervasyon(musteri_adi,musteri_soyadi,musteri_telefon,rezervasyon_saat,rezervasyon_tarih,masa_no) VALUES (@ad,@soyad,@tel,@saat,@tarih,@masano)";
            komut = new SqlCommand(rezervasyon_ekle_sorgu, baglanti);

            //komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@ad", ad.Text);
            komut.Parameters.AddWithValue("@soyad", soyad.Text);
            komut.Parameters.AddWithValue("@tel", telefon.Text);
            komut.Parameters.AddWithValue("@saat", saat.Value);
            komut.Parameters.AddWithValue("@Tarih", tarih.Value);
            komut.Parameters.AddWithValue("@masano", masano.Text);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            rezervasyon_getir();


        }

        private void back2_Click(object sender, EventArgs e)
        {
            rezervasyon rezervasyonform = new rezervasyon();
            rezervasyonform.Show();
            this.Hide();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            string musteri_guncelle_sorgu = "UPDATE rezervasyon SET musteri_adi = @ad,musteri_soyadi = @soyad,musteri_telefon = @tel,rezervasyon_saat = @saat,rezervasyon_tarih = @tarih,masa_no = @masano";
            komut = new SqlCommand(musteri_guncelle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", ad.Text);
            komut.Parameters.AddWithValue("@soyad", soyad.Text);
            komut.Parameters.AddWithValue("@tel", telefon.Text);
            komut.Parameters.AddWithValue("@saat", saat.Value);
            komut.Parameters.AddWithValue("@Tarih", tarih.Value);
            komut.Parameters.AddWithValue("@masano", masano.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            rezervasyon_getir();


        }

        private void rezervasyon_liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            soyad.Text = rezervasyon_liste.CurrentRow.Cells[2].Value.ToString();
            ad.Text = rezervasyon_liste.CurrentRow.Cells[1].Value.ToString();
            telefon.Text = rezervasyon_liste.CurrentRow.Cells[3].Value.ToString();
            saat.Text = rezervasyon_liste.CurrentRow.Cells[4].Value.ToString();
            tarih.Text = rezervasyon_liste.CurrentRow.Cells[5].Value.ToString();
            masano.Text = rezervasyon_liste.CurrentRow.Cells[6].Value.ToString();
        }

        private void kaldir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // DataGridView'den seçili satırı al
            DataGridViewRow selectedRow = rezervasyon_liste.SelectedRows[0];

            // Seçili satırın verilerini al
            string rezervasyonID = selectedRow.Cells["rezervasyonID"].Value.ToString();
            string musteriAdi = selectedRow.Cells["musteri_adi"].Value.ToString();
            string musteriSoyadi = selectedRow.Cells["musteri_soyadi"].Value.ToString();
            string musteriTelefon = selectedRow.Cells["musteri_telefon"].Value.ToString();

            // TimeSpan türündeki değeri uygun bir string formata çevirme
            string rezervasyonSaat = DBNull.Value.Equals(selectedRow.Cells["rezervasyon_saat"].Value) ? null : ((TimeSpan)selectedRow.Cells["rezervasyon_saat"].Value).ToString();

            // DateTime türündeki değeri uygun bir string formata çevirme
            string rezervasyonTarih = DBNull.Value.Equals(selectedRow.Cells["rezervasyon_tarih"].Value) ? null : ((DateTime)selectedRow.Cells["rezervasyon_tarih"].Value).ToString("yyyy-MM-dd");

            string masaNo = selectedRow.Cells["masa_no"].Value.ToString();

            // Veritabanındaki rezervasyon tablosundan silme işlemi
            string silmeSorgusu = $"DELETE FROM rezervasyon WHERE musteri_adi = '{musteriAdi}' AND musteri_soyadi = '{musteriSoyadi}' AND musteri_telefon = '{musteriTelefon}' AND rezervasyon_saat = {(rezervasyonSaat == null ? "NULL" : $"'{rezervasyonSaat}'")} AND rezervasyon_tarih = {(rezervasyonTarih == null ? "NULL" : $"'{rezervasyonTarih}'")} AND masa_no = '{masaNo}'";

            // Veritabanındaki onceki_rezervasyonlar tablosuna ekleme işlemi
            // TimeSpan türündeki değeri uygun bir string formata çevirme
            string eklemeSorgusu = "INSERT INTO onceki_rezervasyonlar (musteri_adi, musteri_soyadi, musteri_telefon, rezervasyon_saat, rezervasyon_tarih, masa_no) " +
                                    $"VALUES ('{musteriAdi}', '{musteriSoyadi}', '{musteriTelefon}', {(rezervasyonSaat == null ? "NULL" : $"'{rezervasyonSaat}'")}, {(rezervasyonTarih == null ? "NULL" : $"'{rezervasyonTarih}'")}, '{masaNo}')";

            using (SqlCommand komut = new SqlCommand(silmeSorgusu, baglanti))
            {
                komut.ExecuteNonQuery();
            }

            using (SqlCommand komut2 = new SqlCommand(eklemeSorgusu, baglanti))
            {
                komut2.ExecuteNonQuery();
            }

            baglanti.Close();

            // DataGridView'den seçili satırı sil
            rezervasyon_liste.Rows.Remove(selectedRow);


        }

    }
}
