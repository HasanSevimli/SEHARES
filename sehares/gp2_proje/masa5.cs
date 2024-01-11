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
    public partial class masa5 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        public masa5()
        {
            InitializeComponent();
        }

        private void masa5_Load(object sender, EventArgs e)
        {
            LoadData();
            masa5_siparis_getir();
        }
        void LoadData()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urun.urun_adi AS urun,urun.urun_fiyat AS fiyat FROM urun WHERE urun_tipi = 'Başlangıç'", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_masa5.DataSource = menutablo;

            baglanti.Close();
        }
        void masa5_siparis_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT masa5.urun_adi AS urun,masa5.urun_fiyat AS fiyat FROM masa5", baglanti);
            DataTable siparistablo = new DataTable();
            da.Fill(siparistablo);
            masa5siparis.DataSource = siparistablo;

            baglanti.Close();
        }
        private void BaslangicMenuDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Menüden bir öğe seçildiğinde çalışacak olay
            DataGridViewSelectedRowCollection selectedRows = menu_masa5.SelectedRows;

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
            masa5siparis.Rows.Add(selectedRow.Cells["urun"].Value, selectedRow.Cells["fiyat"].Value);
        }
        private void TransferData()
        {
            // Seçilen satırı alın
            if (menu_masa5.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = menu_masa5.SelectedRows[0];

                // Seçili satırdan veri alın
                string urunAdi = selectedRow.Cells["urun"].Value.ToString();
                string fiyat = selectedRow.Cells["fiyat"].Value.ToString();

                // Hedef tabloya veriyi eklemek için sorguyu oluşturun
                string insertQuery = $"INSERT INTO masa5 (urun_adi, urun_fiyat) VALUES ('{urunAdi}', '{fiyat}')";

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
                masa5_siparis_getir();
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
            menu_masa5.DataSource = menutablo;

            baglanti.Close();
        }
        void arasicak_menu_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urun.urun_adi AS urun,urun.urun_fiyat AS fiyat FROM urun WHERE urun_tipi = 'Ara Sıcak'", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_masa5.DataSource = menutablo;

            baglanti.Close();
        }
        void anayemek_menu_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urun.urun_adi AS urun,urun.urun_fiyat AS fiyat FROM urun WHERE urun_tipi = 'Ana Yemek'", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_masa5.DataSource = menutablo;

            baglanti.Close();
        }
        void icecek_menu_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urun.urun_adi AS urun,urun.urun_fiyat AS fiyat FROM urun WHERE urun_tipi = 'İçecek'", baglanti);
            DataTable menutablo = new DataTable();
            da.Fill(menutablo);
            menu_masa5.DataSource = menutablo;

            baglanti.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            TransferData();
        }

        private void odeme_kapat_Click(object sender, EventArgs e)
        {
            masa_siparis kapat = new masa_siparis();
            kapat.Show();
            this.Hide();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            // İptal butonuna basıldığında seçili satırı sil
            if (masa5siparis.SelectedRows.Count > 0)
            {
                int rowIndex = masa5siparis.SelectedRows[0].Index;

                // Seçili satırdan veri alın
                string urunAdi = masa5siparis.Rows[rowIndex].Cells["urun"].Value.ToString();
                string fiyat = masa5siparis.Rows[rowIndex].Cells["fiyat"].Value.ToString();

                // Veritabanındaki masa1 tablosundan da silmek için sorguyu oluşturun
                string deleteQuery = $"DELETE FROM masa5 WHERE urun_adi = '{urunAdi}' AND urun_fiyat = '{fiyat}'";

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
                masa5siparis.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Lütfen iptal edilecek satırı seçin.");
            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void odeme_Click(object sender, EventArgs e)
        {
            masa5odeme masaodemeekranınagit = new masa5odeme();
            masaodemeekranınagit.Show();
            this.Hide();
        }
    }
}
