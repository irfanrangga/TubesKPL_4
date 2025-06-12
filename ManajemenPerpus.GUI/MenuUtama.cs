namespace ManajemenPerpus.GUI
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            KoleksiBuku ulasanGui = new KoleksiBuku();
            ulasanGui.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            KoleksiBuku ulasanGui = new KoleksiBuku();
            ulasanGui.Show();
            this.Hide();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Sirkulasi sirkulasi = new Sirkulasi();
            sirkulasi.Show();
            this.Hide();

        }
    }
}
