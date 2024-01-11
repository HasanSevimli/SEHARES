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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using OfficeOpenXml;

namespace gp2_proje
{
    public partial class personel_liste_form : Form
    {
        SqlConnection baglanti;

        SqlDataAdapter da;
        public personel_liste_form()
        {
            InitializeComponent();
        }

        private void personelexcel(DataTable personelTable, string excelFileName)
        {
            try
            {

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Masaüstü yolunu desktopPath e atama işlemini yaptım
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Excel dosya yolunu belirttim
                string excelFilePath = Path.Combine(desktopPath, excelFileName);

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Personel");

                    // Başlık eklemek için
                    for (int i = 1; i <= personelTable.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = personelTable.Columns[i - 1].ColumnName;
                    }

                    // Veri satırlarını ekleyin
                    for (int i = 0; i < personelTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < personelTable.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = personelTable.Rows[i][j];
                        }
                    }

                    // Excel dosyasını masaüstüne kaydet
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
        void personel_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT * FROM personel", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            personel_ana_liste.DataSource = tablo;

            baglanti.Close();

        }
        void eski_personel_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT * FROM eski_personel", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            personel_ana_liste.DataSource = tablo;

            baglanti.Close();

        }
        private void button20_Click(object sender, EventArgs e)
        {
            personel_ekle_form form8gecis = new personel_ekle_form();
            form8gecis.Show();
            this.Hide();
        }

        private void personel_sil_Click(object sender, EventArgs e)
        {

        }

        private void back3_Click(object sender, EventArgs e)
        {
            admin form10gecis = new admin();
            form10gecis.Show();
            this.Hide();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personel_ana_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personel_liste_form_Load(object sender, EventArgs e)
        {
            personel_getir();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eski_personel_gor_Click(object sender, EventArgs e)
        {
            eski_personel_getir();
        }

        private void personel_gor_Click(object sender, EventArgs e)
        {
            personel_getir();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            // DataGridView'deki verileri bir DataTable'a kopyala
            DataTable personelTable = new DataTable();
            foreach (DataGridViewColumn column in personel_ana_liste.Columns)
            {
                personelTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in personel_ana_liste.Rows)
            {
                DataRow dataRow = personelTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                personelTable.Rows.Add(dataRow);
            }

            // DataTable'ı Excel olarak dışa aktar
            personelexcel(personelTable, "Personel.xlsx");
        }
    }
}
