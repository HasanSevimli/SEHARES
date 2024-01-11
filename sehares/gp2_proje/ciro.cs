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
using OfficeOpenXml;

namespace gp2_proje
{
    public partial class ciro : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        public ciro()
        {
            InitializeComponent();
        }

        private void ciro_Load(object sender, EventArgs e)
        {
            ciro_getir();
        }

        void kart_ciro_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT SUM(odeme.urun_fiyat) AS kart FROM odeme WHERE odeme_tur = 'kart';", baglanti);
            DataTable cirotablo = new DataTable();
            da.Fill(cirotablo);


            genelciro.DataSource = cirotablo;

            baglanti.Close();
        }
        void nakit_ciro_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT SUM(odeme.urun_fiyat) AS nakit FROM odeme WHERE odeme_tur = 'nakit';", baglanti);
            DataTable cirotablo = new DataTable();
            da.Fill(cirotablo);


            genelciro.DataSource = cirotablo;

            baglanti.Close();
        }
        void genel_ciro_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT SUM(odeme.urun_fiyat) AS genel FROM odeme;", baglanti);
            DataTable cirotablo = new DataTable();
            da.Fill(cirotablo);


            genelciro.DataSource = cirotablo;

            baglanti.Close();
        }
        void kart_ciro()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT odeme.urun_adi AS urun,odeme.urun_fiyat AS fiyat,odeme.hesap_tarih AS Tarih,odeme.odeme_tur AS odeme FROM odeme WHERE odeme.odeme_tur = 'kart'", baglanti);
            DataTable cirotablo = new DataTable();
            da.Fill(cirotablo);


            genelciro.DataSource = cirotablo;

            baglanti.Close();
        }
        void nakit_ciro()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT odeme.urun_adi AS urun,odeme.urun_fiyat AS fiyat,odeme.hesap_tarih AS Tarih,odeme.odeme_tur AS odeme FROM odeme WHERE odeme.odeme_tur = 'nakit'", baglanti);
            DataTable cirotablo = new DataTable();
            da.Fill(cirotablo);


            genelciro.DataSource = cirotablo;

            baglanti.Close();
        }

        void ciro_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT odeme.urun_adi AS urun,odeme.urun_fiyat AS fiyat,odeme.hesap_tarih AS Tarih,odeme.odeme_tur AS odeme FROM odeme", baglanti);
            DataTable cirotablo = new DataTable();
            da.Fill(cirotablo);


            genelciro.DataSource = cirotablo;

            baglanti.Close();
        }
        void ciro_filtrele_getir(string seciliTarih)
        {

            using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True"))
            {
                baglanti.Open();

                // SQL sorgusunu ve parametrelerini uygula
                string sqlSorgusu = "SELECT urun_adi AS urun, urun_fiyat AS fiyat, hesap_tarih AS tarih, odeme_tur AS odeme FROM odeme WHERE CONVERT(varchar, hesap_tarih, 23) = @SeciliTarih";
                using (SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@SeciliTarih", seciliTarih);

                    // Verileri çek
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DataGridView'ın DataSource'ını güncelle
                    genelciro.DataSource = dt;
                }
            }
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // DateTimePicker'dan seçilen tarihi al
            DateTime seciliTarih = dateTimePicker.Value;

            // Tarih formatını uygun hale getir
            string formatliTarih = seciliTarih.ToString("yyyy-MM-dd");

            // DataGridView'da belirtilen tarihe ait verileri göster
            ciro_filtrele_getir(formatliTarih);
        }



        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            // DataGridView'deki verileri bir DataTable'a kopyala
            DataTable ciroTable = new DataTable();
            foreach (DataGridViewColumn column in genelciro.Columns)
            {
                ciroTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in genelciro.Rows)
            {
                DataRow dataRow = ciroTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                ciroTable.Rows.Add(dataRow);
            }

            // DataTable'ı Excel olarak dışa aktar
            ciroexcel(ciroTable, "Ciro.xlsx");
        }
        private void ciroexcel(DataTable ciroTable, string excelFileName)
        {
            try
            {
                // Excel dosyası için lisans ayarı
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string excelFilePath = Path.Combine(desktopPath, excelFileName);

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Ciro");

                    // Başlık eklemek için
                    for (int i = 1; i <= ciroTable.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = ciroTable.Columns[i - 1].ColumnName;
                    }

                    // Veri satırlarını ekleyin
                    for (int i = 0; i < ciroTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < ciroTable.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = ciroTable.Rows[i][j];
                        }
                    }

                    // Excel dosyasını kaydet
                    File.WriteAllBytes(excelFilePath, package.GetAsByteArray());
                }

                // Başarılı mesajı göster
                MessageBox.Show("Excel olarak kaydedildi: " + excelFilePath, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajını göster
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Hatanın detaylarını bir log dosyasına yaz
                System.IO.File.WriteAllText("error_log.txt", ex.ToString());
            }
        }

        private void back1_Click(object sender, EventArgs e)
        {
            admin admingecis = new admin();
            admingecis.Show();
            this.Hide();
        }

        private void kart_Click(object sender, EventArgs e)
        {
            kart_ciro_getir();
        }

        private void tumu_Click(object sender, EventArgs e)
        {
            ciro_getir();
        }

        private void genel_Click(object sender, EventArgs e)
        {
            genel_ciro_getir();
        }

        private void nakit_Click(object sender, EventArgs e)
        {
            nakit_ciro_getir();
        }

        private void kartgenel_Click(object sender, EventArgs e)
        {
            kart_ciro();
        }

        private void nakitgenel_Click(object sender, EventArgs e)
        {
            nakit_ciro();
        }
    }
}
