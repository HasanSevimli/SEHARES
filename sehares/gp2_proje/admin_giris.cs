using System.Data.SqlClient;

namespace gp2_proje
{
    public partial class admin_giris : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NOTHH0Q\\SQLEXPRESS01; Initial Catalog=DB; Integrated Security=TRUE");
        public admin_giris()
        {

            InitializeComponent();
        }
        bool isThere;

        private void admin_buton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;

            connection.Open();
            SqlCommand command = new SqlCommand("Select*from admin", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                if (username == reader["adminmail"].ToString().TrimEnd() && pass == reader["sifre"].ToString().TrimEnd())
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
                admin form10gecis = new admin();
                form10gecis.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("giriş yapamadınız.");
            }
            connection.Close();
        }

        private void admin_giris_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back5_Click(object sender, EventArgs e)
        {
            anasayfa form1gecis = new anasayfa();
            form1gecis.Show();
            this.Hide();
        }
    }
}
