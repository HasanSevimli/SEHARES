namespace gp2_proje
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personel_buton_Click(object sender, EventArgs e)
        {
            personel_giris personelgecis = new personel_giris();
            personelgecis.Show();
            this.Hide();
        }

        private void admin_buton_Click(object sender, EventArgs e)
        {
            admin_giris admingecis = new admin_giris();
            admingecis.Show();
            this.Hide();
        }
    }
}