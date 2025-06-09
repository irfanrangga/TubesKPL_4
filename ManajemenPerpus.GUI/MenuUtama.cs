namespace ManajemenPerpus.GUI
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sirkulasi sirkulasiForm = new Sirkulasi();
            sirkulasiForm.ShowDialog();
            
        }
    }
}
