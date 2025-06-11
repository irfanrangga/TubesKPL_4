namespace ManajemenPerpus.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MenuUtama());
                //Application.Run(new LaporanStatisticGui());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error saat startup");
            }
        }

    }
}