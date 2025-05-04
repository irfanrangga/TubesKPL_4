using System;
using System.Linq;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturNotifikasiOtomatis
    {
        private readonly NotifikasiService _notifikasiService;

        public enum StateNotifikasiOtomatis
        {
            StateMenuNotifikasiOtomatis,
            StateCekInboxNotifikasi,
            StateKeluarNotifikasiOtomatis
        }

        public FiturNotifikasiOtomatis()
        {
            _notifikasiService = new NotifikasiService();
        }

        public ProgramState MenuNotifikasiOtomatis()
        {
            StateNotifikasiOtomatis currentState = StateNotifikasiOtomatis.StateMenuNotifikasiOtomatis;

            while (currentState != StateNotifikasiOtomatis.StateKeluarNotifikasiOtomatis)
            {
                switch (currentState)
                {
                    case StateNotifikasiOtomatis.StateMenuNotifikasiOtomatis:
                        currentState = TampilkanMenuNotifikasi();
                        break;
                    case StateNotifikasiOtomatis.StateCekInboxNotifikasi:
                        currentState = CekInboxNotifikasi();
                        break;
                }
            }

            return ProgramState.StateMenuUtama;
        }

        public StateNotifikasiOtomatis TampilkanMenuNotifikasi()
        {
            Console.Clear();
            Console.WriteLine("=== FITUR NOTIFIKASI OTOMATIS ===");
            Console.WriteLine("1. Cek Inbox Notifikasi");
            Console.WriteLine("2. Keluar");
            Console.Write("Pilih opsi: ");

            var input = Console.ReadLine();
            return input switch
            {
                "1" => StateNotifikasiOtomatis.StateCekInboxNotifikasi,
                "2" => StateNotifikasiOtomatis.StateKeluarNotifikasiOtomatis,
                _ => StateNotifikasiOtomatis.StateMenuNotifikasiOtomatis
            };
        }

        public StateNotifikasiOtomatis CekInboxNotifikasi()
        {
            Console.Clear();
            Console.WriteLine("=== DAFTAR NOTIFIKASI ===");

            var allNotifikasi = _notifikasiService.GetAllNotifikasi();

            if (!allNotifikasi.Any())
            {
                Console.WriteLine("\nTidak ada notifikasi yang tersedia.");
            }
            else
            {


                // Display only the notification messages, newest first
                foreach (var notif in allNotifikasi.OrderByDescending(n => n.TanggalNotifikasi))
                {
                    Console.WriteLine($"- {notif.IsiNotifikasi}");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu...");
            Console.ReadKey();

            return StateNotifikasiOtomatis.StateMenuNotifikasiOtomatis;
        }

        public void UpdateNotifikasi()
        {
            DateTime currentTime = DateTime.Now;

            // Implement your automatic notification logic here:
            // 1. Check for upcoming returns (2 days before, 1 day before, due date)
            // 2. Check for overdue books and create fine notifications
            // 3. Check for new books added in last 3 days

            // Example:
            // _notifikasiService.SendNotifikasi("user123", "Buku 'C# Programming' akan jatuh tempo besok");


            Console.WriteLine("Notifikasi otomatis diperbarui.");
        }
    }
}