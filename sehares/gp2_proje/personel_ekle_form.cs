using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace gp2_proje
{
    public partial class personel_ekle_form : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;


        public personel_ekle_form()
        {
            InitializeComponent();



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void personelekle_Click(object sender, EventArgs e)
        {
            string telno = tel.Text;
            string tcno = tc.Text;
            int sayi;
            int tcsayi;



            if (int.TryParse(telno, out sayi) || telno.Length != 11)
            {

                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                tel.Clear();
                return;

            }
            else if (int.TryParse(tcno, out tcsayi) || tcno.Length != 11)
            {

                MessageBox.Show("Lütfen geçerli bir TC Kimlik numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                tc.Clear();
                return;
            }
            else if (cinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen cisniyet seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //tarih ve saat bilgisini aldım


            string personel_ekle_sorgu = "INSERT INTO personel(personel_adi,personel_soyadi,personel_tel,vardiyabas,vardiyason,personel_tc,personel_dt,personel_mail,personel_sifre,cinsiyet) VALUES (@ad,@soyad,@tel,@vardiyabas,@vardiyabit,@tc,@dt,@mail,@pass,@cinsiyet)";
            komut = new SqlCommand(personel_ekle_sorgu, baglanti);

            //komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@ad", ad.Text);
            komut.Parameters.AddWithValue("@soyad", soy.Text);
            komut.Parameters.AddWithValue("@tel", tel.Text);
            komut.Parameters.AddWithValue("@vardiyabas", vardiyabas.Value);
            komut.Parameters.AddWithValue("@vardiyabit", vardiyabit.Value);
            komut.Parameters.AddWithValue("@tc", tc.Text);
            komut.Parameters.AddWithValue("@dt", datetime.Value);
            komut.Parameters.AddWithValue("@mail", email.Text);
            komut.Parameters.AddWithValue("@pass", pass.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            personel_getir();


        }

        private void back4_Click(object sender, EventArgs e)
        {
            personel_liste_form form7gecis = new personel_liste_form();
            form7gecis.Show();
            this.Hide();
        }

        void personel_getir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            baglanti.Open();

            da = new SqlDataAdapter("SELECT * FROM personel", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            personel_liste.DataSource = tablo;

            baglanti.Close();

        }
        private void personel_ekle_form_Load(object sender, EventArgs e)
        {
            personel_getir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personel_liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            soy.Text = personel_liste.CurrentRow.Cells[2].Value.ToString();
            ad.Text = personel_liste.CurrentRow.Cells[1].Value.ToString();
            txtid.Text = personel_liste.CurrentRow.Cells[0].Value.ToString();
            tc.Text = personel_liste.CurrentRow.Cells[6].Value.ToString();
            datetime.Text = personel_liste.CurrentRow.Cells[7].Value.ToString();
            pass.Text = personel_liste.CurrentRow.Cells[9].Value.ToString();
            cinsiyet.Text = personel_liste.CurrentRow.Cells[10].Value.ToString();
            tel.Text = personel_liste.CurrentRow.Cells[3].Value.ToString();
            email.Text = personel_liste.CurrentRow.Cells[8].Value.ToString();
            txtid.Text = personel_liste.CurrentRow.Cells[0].Value.ToString();
            vardiyabas.Text = personel_liste.CurrentRow.Cells[4].Value.ToString();
            vardiyabit.Text = personel_liste.CurrentRow.Cells[5].Value.ToString();








        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personel_kaldir_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            // DataGridView'den seçili satırı al
            DataGridViewRow selectedRow = personel_liste.SelectedRows[0];

            // Seçili satırın verilerini al
            string personelID = selectedRow.Cells["personelID"].Value.ToString();
            string personeladi = selectedRow.Cells["personel_adi"].Value.ToString();
            string personelsoyadi = selectedRow.Cells["personel_soyadi"].Value.ToString();
            string personeltel = selectedRow.Cells["personel_tel"].Value.ToString();
            string personeltc = selectedRow.Cells["personel_tc"].Value.ToString();
            string personelmail = selectedRow.Cells["personel_mail"].Value.ToString();
            string personelcinsiyet = selectedRow.Cells["cinsiyet"].Value.ToString();

            //tarih ve saat bilgisini aldım




            // DateTime türündeki değeri uygun bir string formata çevirme
            string personeldt = DBNull.Value.Equals(selectedRow.Cells["personel_dt"].Value) ? null : ((DateTime)selectedRow.Cells["personel_dt"].Value).ToString("yyyy-MM-dd");



            // Veritabanındaki rezervasyon tablosundan silme işlemi
            string personel_kaldir_sorgu = "DELETE FROM personel WHERE personelID = @personelID";
            komut = new SqlCommand(personel_kaldir_sorgu, baglanti);
            komut.Parameters.AddWithValue("@personelID", Convert.ToInt32(txtid.Text));

            komut.ExecuteNonQuery();

            // Veritabanındaki eski_rezervasyonlar tablosuna ekleme işlemi
            string eklemeSorgusu = "INSERT INTO eski_personel (personel_adi, personel_soyadi, personel_tel, personel_tc, personel_mail, cinsiyet,personel_dt) " +
                                    $"VALUES ('{personeladi}', '{personelsoyadi}', '{personeltel}', '{personeltc}', '{personelmail}','{personelcinsiyet}', {(personeldt == null ? "NULL" : $"'{personeldt}'")})";


            // Düzeltme: SqlCommand komut2 = new SqlCommand(personel_kaldir_sorgu, baglanti) yerine SqlCommand komut2 = new SqlCommand(eklemeSorgusu, baglanti) olarak değiştirildi.
            using (SqlCommand komut2 = new SqlCommand(eklemeSorgusu, baglanti))
            {
                komut2.ExecuteNonQuery();
            }

            baglanti.Close();

            // DataGridView'den seçili satırı sil
            personel_liste.Rows.Remove(selectedRow);

            personel_getir();


        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            string telno = tel.Text;
            string tcno = tc.Text;
            int sayi;
            int tcsayi;


            if (int.TryParse(telno, out sayi) || telno.Length != 11)
            {

                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                tel.Clear();
                return;

            }
            else if (int.TryParse(tcno, out tcsayi) || tcno.Length != 11)
            {

                MessageBox.Show("Lütfen geçerli bir TC Kimlik numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                tc.Clear();
                return;
            }
            else if (cinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            string personel_guncelle_sorgu = "UPDATE personel SET personel_adi = @ad,personel_soyadi = @soyad,personel_tel = @tel,vardiyabas = @vardiyabas,vardiyason = @vardiyabit,personel_tc = @tc,personel_dt = @dt,personel_mail = @mail,personel_sifre = @pass,cinsiyet = @cinsiyet WHERE personelID = @id";
            komut = new SqlCommand(personel_guncelle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
            komut.Parameters.AddWithValue("@ad", ad.Text);
            komut.Parameters.AddWithValue("@soyad", soy.Text);
            komut.Parameters.AddWithValue("@tel", tel.Text);
            komut.Parameters.AddWithValue("@vardiyabas", vardiyabas.Text);
            komut.Parameters.AddWithValue("@vardiyabit", vardiyabit.Text);
            komut.Parameters.AddWithValue("@tc", tc.Text);
            komut.Parameters.AddWithValue("@dt", datetime.Value);
            komut.Parameters.AddWithValue("@mail", email.Text);
            komut.Parameters.AddWithValue("@pass", pass.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            personel_getir();










        }

        private void tel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
