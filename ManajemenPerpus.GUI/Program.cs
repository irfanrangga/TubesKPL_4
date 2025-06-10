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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuUtama());
            //Application.Run(new NotifikasiGui("U123")); //Manggil Notifikasi Perlu ID User yang lagi login
        }
    }
}