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
    public partial class masa6odeme : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        public masa6odeme()
        {
            InitializeComponent();
        }

        private void masa6odeme_Load(object sender, EventArgs e)
        {
            masa_odeme_getir();
            toplam_fiyat_getir();
        }
        void masa_odeme_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("UPDATE masa6 SET urun_fiyat = urun_fiyat * 1.05  SELECT masa6.urun_adi AS urun,masa6.urun_fiyat AS fiyat FROM masa6", baglanti);
            DataTable siparistablo = new DataTable();
            da.Fill(siparistablo);

            masaodeme.DataSource = siparistablo;

            baglanti.Close();
        }
        void toplam_fiyat_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT SUM(masa6.urun_fiyat) AS toplamfiyat FROM masa6", baglanti);
            DataTable siparistablo = new DataTable();
            da.Fill(siparistablo);
            masatoplam.DataSource = siparistablo;

            baglanti.Close();
        }

        private void ode_Click(object sender, EventArgs e)
        {
            if (masaodeme.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = masaodeme.SelectedRows[0];

                // Satırın verilerini aldım
                string urunAdi = selectedRow.Cells["urun"].Value.ToString();
                decimal odemeMiktari = Convert.ToDecimal(selectedRow.Cells["fiyat"].Value);

                //tarih ve saat bilgisini aldım
                DateTime odemeTarihi = DateTime.Now;

                //combobox da seçili olan değeri aldım
                string odemeTur = odemetur.SelectedItem as string;

                // odemeTur null mı kontrol etim
                if (string.IsNullOrEmpty(odemeTur))
                {
                    // Kullanıcı bir değer seçmediğinde uyarı mesajını göster
                    MessageBox.Show("Lütfen bir ödeme türü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return; // Fonksiyonu burada sonlandır, çünkü gerekli bilgi eksik
                }


                // Veritabanına ekleme işlemi için SQL sorgusu
                string sqlSorgusu = "INSERT INTO odeme (urun_adi, urun_fiyat,hesap_tarih,odeme_tur) VALUES (@urun, @fiyat,@Tarih,@odemeTur)";

                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True"))
                {
                    using (SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti))
                    {
                        //datagridview da seçili olan satırı veri tabanına ekleyecek komut satırını yazdım
                        komut.Parameters.AddWithValue("@urun", urunAdi);
                        komut.Parameters.AddWithValue("@fiyat", odemeMiktari);
                        //tarih ve saat bilgisini veri tabanına ekleyecek komut satırını yazdım
                        komut.Parameters.AddWithValue("@Tarih", odemeTarihi);
                        //combobox da seçili olan dğeri veri tabanına ekleyecek komut satırını yazdım
                        komut.Parameters.AddWithValue("@OdemeTur", odemeTur);

                        // Bağlantıyı açın, komutu çalıştırın ve bağlantıyı kapatın
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                }
                // İptal butonuna basıldığında seçili satırı sil
                if (masaodeme.SelectedRows.Count > 0)
                {

                    int rowIndex = masaodeme.SelectedRows[0].Index;

                    // Seçili satırdan veri alın
                    string urunAd = masaodeme.Rows[rowIndex].Cells["urun"].Value.ToString();
                    string fiyat = masaodeme.Rows[rowIndex].Cells["fiyat"].Value.ToString();

                    // Veritabanındaki masa1 tablosundan da silmek için sorguyu oluşturun
                    string deleteQuery = $"DELETE FROM masa6 WHERE urun_adi = '{urunAd}' AND urun_fiyat = '{fiyat}'";

                    // Hedef tabloya bağlanın
                    baglanti.Open();

                    // Komutu yürütün
                    using (SqlCommand command = new SqlCommand(deleteQuery, baglanti))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Hedef tabloya bağlantıyı kapatın
                    baglanti.Close();

                    // DataGridView'dan seçili satırı sil
                    masaodeme.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Lütfen iptal edilecek satırı seçin.");
                }


            }
            else
            {
                MessageBox.Show("Masada herhangi bir sipariş yok");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            masa6 masayageridon = new masa6();
            masayageridon.Show();
            this.Hide();
        }
    }
}
