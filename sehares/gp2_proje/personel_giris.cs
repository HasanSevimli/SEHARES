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

namespace gp2_proje
{
    public partial class personel_giris : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=TRUE");
        public personel_giris()
        {
            InitializeComponent();
        }
        bool isThere;
        private void person_button_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;

            connection.Open();
            SqlCommand command = new SqlCommand("Select*from personel", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                if (kullaniciadi == reader["personel_mail"].ToString().TrimEnd() && sifre == reader["personel_sifre"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }



            }

            if (isThere)
            {
                MessageBox.Show("başarıyla giriş yaptınız.");
                personel form11gecis = new personel();
                form11gecis.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("giriş yapamadınız.");
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back6_Click(object sender, EventArgs e)
        {
            anasayfa form1gecis = new anasayfa();
            form1gecis.Show();
            this.Hide();
        }
    }
}
