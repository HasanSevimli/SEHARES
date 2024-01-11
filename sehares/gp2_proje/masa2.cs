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
    public partial class masa2 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        public masa2()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urun.urun_adi AS urun,urun.urun_fiyat AS fiyat FROM urun WHERE urun_tipi = 'Başlangıç'", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_masa2.DataSource = menutablo;

            baglanti.Close();
        }
        void masa2_siparis_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT masa2.urun_adi AS urun,masa2.urun_fiyat AS fiyat FROM masa2", baglanti);
            DataTable siparis2tablo = new DataTable();
            da.Fill(siparis2tablo);
            masa2siparis.DataSource = siparis2tablo;

            baglanti.Close();
        }
        private void BaslangicMenuDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Menüden bir öğe seçildiğinde çalışacak olay
            DataGridViewSelectedRowCollection selectedRows = menu_masa2.SelectedRows;

            // Seçilen öğeyi sipariş tablosuna ekleyen yöntemi çağır
            foreach (DataGridViewRow row in selectedRows)
            {
                UrunuSiparisTablosunaEkle(row);
                TransferData(); // TransferData metodunu burada çağırın
            }
        }

        private void UrunuSiparisTablosunaEkle(DataGridViewRow selectedRow)
        {
            // Sipariş tablosuna seçilen öğeyi ekleyin
            masa2siparis.Rows.Add(selectedRow.Cells["urun"].Value, selectedRow.Cells["fiyat"].Value);
        }

        private void TransferData()
        {
            // Seçilen satırı alın
            if (menu_masa2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = menu_masa2.SelectedRows[0];

                // Seçili satırdan veri alın
                string urunAdi = selectedRow.Cells["urun"].Value.ToString();
                string fiyat = selectedRow.Cells["fiyat"].Value.ToString();

                // Hedef tabloya veriyi eklemek için sorguyu oluşturun
                string insertQuery = $"INSERT INTO masa2 (urun_adi, urun_fiyat) VALUES ('{urunAdi}', '{fiyat}')";

                // Hedef tabloya bağlanın
                baglanti.Open();

                // Komutu yürütün
                using (SqlCommand command = new SqlCommand(insertQuery, baglanti))
                {
                    command.ExecuteNonQuery();
                }

                // Hedef tabloya bağlantıyı kapatın
                baglanti.Close();

                // Veriyi aktardıktan sonra DataGridView'i güncelleyin
                masa2_siparis_getir();
            }
            else
            {
                MessageBox.Show("Lütfen aktarılacak satırı seçin.");
            }
        }

        void baslangic_menu_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urun.urun_adi AS urun,urun.urun_fiyat AS fiyat FROM urun WHERE urun_tipi = 'Başlangıç'", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_masa2.DataSource = menutablo;

            baglanti.Close();
        }
        void arasicak_menu_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urun.urun_adi AS urun,urun.urun_fiyat AS fiyat FROM urun WHERE urun_tipi = 'Ara Sıcak'", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_masa2.DataSource = menutablo;

            baglanti.Close();
        }
        void anayemek_menu_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urun.urun_adi AS urun,urun.urun_fiyat AS fiyat FROM urun WHERE urun_tipi = 'Ana Yemek'", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_masa2.DataSource = menutablo;

            baglanti.Close();
        }
        void icecek_menu_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urun.urun_adi AS urun,urun.urun_fiyat AS fiyat FROM urun WHERE urun_tipi = 'İçecek'", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_masa2.DataSource = menutablo;

            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TransferData();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            // İptal butonuna basıldığında seçili satırı sil
            if (masa2siparis.SelectedRows.Count > 0)
            {
                int rowIndex = masa2siparis.SelectedRows[0].Index;

                // Seçili satırdan veri alın
                string urunAdi = masa2siparis.Rows[rowIndex].Cells["urun"].Value.ToString();
                string fiyat = masa2siparis.Rows[rowIndex].Cells["fiyat"].Value.ToString();

                // Veritabanındaki masa1 tablosundan da silmek için sorguyu oluşturun
                string deleteQuery = $"DELETE FROM masa2 WHERE urun_adi = '{urunAdi}' AND urun_fiyat = '{fiyat}'";

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
                masa2siparis.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Lütfen iptal edilecek satırı seçin.");
            }
        }

        private void baslangic_Click(object sender, EventArgs e)
        {
            baslangic_menu_getir();
        }

        private void arasicak_Click(object sender, EventArgs e)
        {
            arasicak_menu_getir();
        }

        private void anayemek_Click(object sender, EventArgs e)
        {
            anayemek_menu_getir();
        }

        private void icecek_Click(object sender, EventArgs e)
        {
            icecek_menu_getir();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
            masa2_siparis_getir();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void odeme_kapat_Click(object sender, EventArgs e)
        {
            masa_siparis kapat = new masa_siparis();
            kapat.Show();
            this.Hide();
        }

        private void odeme_Click(object sender, EventArgs e)
        {
            masa2odeme masaodemeekranınagit = new masa2odeme();
            masaodemeekranınagit.Show();
            this.Hide();
        }
    }
}
