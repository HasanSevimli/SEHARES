using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class masa_siparis : Form
    {
        SqlConnection baglanti;
        public masa_siparis()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True");
            MasaRenkleriKontrolEt();
        }

        private void MasaRenkleriKontrolEt()
        {
            try
            {
                baglanti.Open();

                for (int i = 1; i < 7; i++)
                {
                    SqlCommand komut = new SqlCommand($"SELECT COUNT(*) FROM masa{i} WHERE urun_adi IS NOT NULL", baglanti);
                    int urunAdiSayisi = (int)komut.ExecuteScalar();

                    // Eğer urun_adi sütununda herhangi bir değer varsa diye kontrol ediyorum
                    if (urunAdiSayisi > 0)
                    {
                        foreach (Control control in Controls)
                        {
                            if (control is Button && control.Name == $"M{i}")
                            {
                                control.BackColor = System.Drawing.Color.LightGray;
                            }
                        }
                    }
                    else
                    {
                        // Eğer urun_adi sütunu boşsa, ilgili butonların rengini gri yaptım
                        foreach (Control control in Controls)
                        {
                            if (control is Button && control.Name == $"M{i}")
                            {
                                control.BackColor = System.Drawing.Color.Bisque;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void MasalariKontrolEt()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=True"))
            {
                baglanti.Open();

                // Bugünün tarihini ve saatinin öncesindeki rezervasyonları kontrol ettirdim
                string sorgu = "SELECT rezervasyonID, masa_no FROM rezervasyon " +
                               "WHERE musteri_adi IS NOT NULL AND rezervasyon_tarih <= GETDATE() AND rezervasyon_saat <= FORMAT(GETDATE(), 'HH:mm:ss')";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string rezervasyonID = reader["rezervasyonID"].ToString();
                            string masaNo = reader["masa_no"].ToString();

                            // Masa numarasına karşılık gelen butonun rengini değiştirtdim
                            DegistirButonRengi(masaNo);
                        }
                    }
                }
            }
        }

        private void DegistirButonRengi(string masaNo)
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control.Name == $"{masaNo}")
                {
                    control.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        private void personel_buton_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void M3_Click(object sender, EventArgs e)
        {
            masa3 gitmasa3 = new masa3();
            gitmasa3.Show();
            this.Hide();
        }

        private void M5_Click(object sender, EventArgs e)
        {
            masa5 gitmasa5 = new masa5();
            gitmasa5.Show();
            this.Hide();
        }

        private void back1_Click(object sender, EventArgs e)
        {
            personel form11gecis = new personel();
            form11gecis.Show();
            this.Hide();
        }

        private void rezerv_Click(object sender, EventArgs e)
        {

        }

        private void masa_siparis_Load(object sender, EventArgs e)
        {
            MasalariKontrolEt();
        }

        private void M1_Click(object sender, EventArgs e)
        {
            masa1 gitmasa1 = new masa1();
            gitmasa1.Show();
            this.Hide();
        }

        private void M2_Click(object sender, EventArgs e)
        {
            masa2 gitmasa2 = new masa2();
            gitmasa2.Show();
            this.Hide();
        }

        private void M4_Click(object sender, EventArgs e)
        {
            masa4 gitmasa4 = new masa4();
            gitmasa4.Show();
            this.Hide();
        }

        private void M6_Click(object sender, EventArgs e)
        {
            masa6 gitmasa6 = new masa6();
            gitmasa6.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
