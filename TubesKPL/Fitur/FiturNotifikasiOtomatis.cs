using System;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturNotifikasiOtomatis
    {
        public void TampilkanMenuNotifikasi()
        {
            Console.Clear();
            Console.WriteLine("=== FITUR NOTIFIKASI OTOMATIS ===");
            Console.WriteLine("1. Pengingat Pengembalian");
            Console.WriteLine("2. Notifikasi Denda");
            Console.WriteLine("3. Informasi Buku Baru");
            Console.WriteLine("4. Pemberitahuan Status Keanggotaan");
            Console.WriteLine("0. Kembali ke Menu Utama");
            Console.Write("Pilih opsi: ");

            //int pilihan;
            //if (int.TryParse(Console.ReadLine(), out pilihan))
            //{
            //    switch (pilihan)
            //    {
            //        case 1:
            //            TampilkanPengingatPengembalian();
            //            break;
            //        case 2:
            //            TampilkanNotifikasiDenda();
            //            break;
            //        case 3:
            //            TampilkanInformasiBukuBaru();
            //            break;
            //        case 4:
            //            TampilkanPemberitahuanStatusKeanggotaan();
            //            break;
            //        case 0:
            //            return;
            //        default:
            //            Console.WriteLine("Pilihan tidak valid.");
            //            Console.ReadKey();
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Input tidak valid. Harap masukkan angka.");
            //    Console.ReadKey();
            //}
        }

    }
}
