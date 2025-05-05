using System;
using ManajemenPerpus.CLI.Service;
using ManajemenPerpus.Core.Models;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturManajemenPengguna
    {
        private PenggunaService _penggunaService;

        public FiturManajemenPengguna()
        {
            _penggunaService = new PenggunaService();
        }

        public ProgramState MenuManajemenPengguna()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MANAJEMEN PENGGUNA & KEANGGOTAAN ===");
                Console.WriteLine("1. Tambah Anggota Baru");
                Console.WriteLine("2. Edit Username & Password");
                Console.WriteLine("3. Edit Data Pengguna (Kecuali Username & Password)");
                Console.WriteLine("4. Hapus Anggota");
                Console.WriteLine("5. Lihat Daftar Anggota");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.Write("Pilih opsi: ");

                int pilihan;
                if (int.TryParse(Console.ReadLine(), out pilihan))
                {
                    switch (pilihan)
                    {
                        case 0: return ProgramState.StateMenuUtama;
                        case 1: TambahAnggota(); break;
                        case 2: EditUsernamePassword(); break;
                        case 3: EditDataPengguna(); break;
                        case 4: HapusAnggota(); break;
                        case 5: TampilkanSemuaPengguna(); break;
                        default:
                            Console.WriteLine("Opsi tidak tersedia.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Harap masukkan angka.");
                    Console.ReadKey();
                }
            }
        }

        private void TambahAnggota()
        {
            Console.Clear();
            Console.WriteLine("--- Tambah Pengguna Baru ---");

            Console.Write("Kelas Pengguna (Admin/Anggota): ");
            string userClass = Console.ReadLine();

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Fullname: ");
            string fullname = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            var role = userClass.ToLower() == "admin" ? Pengguna.ROLEPENGGUNA.admin : Pengguna.ROLEPENGGUNA.anggota;
            _penggunaService.AddPengguna(userClass, username, password, role, fullname, email, phone, address);

            Console.WriteLine("Pengguna berhasil ditambahkan!");
            Console.ReadKey();
        }

        private void EditUsernamePassword()
        {
            Console.Clear();
            Console.WriteLine("--- Edit Username & Password ---");
            Console.Write("Masukkan ID Pengguna: ");
            string id = Console.ReadLine();

            var pengguna = _penggunaService.GetPenggunaById(id);
            if (pengguna != null)
            {
                Console.Write("Username baru: ");
                pengguna.Username = Console.ReadLine();

                Console.Write("Password baru: ");
                pengguna.Password = Console.ReadLine();

                Console.WriteLine("Username dan password berhasil diperbarui.");
            }
            else
            {
                Console.WriteLine("Pengguna tidak ditemukan.");
            }

            Console.ReadKey();
        }

        private void EditDataPengguna()
        {
            Console.Clear();
            Console.WriteLine("--- Edit Data Pengguna ---");
            Console.Write("Masukkan ID Pengguna: ");
            string id = Console.ReadLine();

            var pengguna = _penggunaService.GetPenggunaById(id);
            if (pengguna != null)
            {
                Console.Write("Fullname baru: ");
                pengguna.Fullname = Console.ReadLine();

                Console.Write("Email baru: ");
                pengguna.Email = Console.ReadLine();

                Console.Write("Phone baru: ");
                pengguna.Phone = Console.ReadLine();

                Console.Write("Address baru: ");
                pengguna.Address = Console.ReadLine();

                Console.WriteLine("Data pengguna berhasil diperbarui.");
            }
            else
            {
                Console.WriteLine("Pengguna tidak ditemukan.");
            }

            Console.ReadKey();
        }

        private void HapusAnggota()
        {
            Console.Clear();
            Console.WriteLine("--- Hapus Pengguna ---");
            Console.Write("Masukkan ID Pengguna: ");
            string id = Console.ReadLine();

            bool sukses = _penggunaService.DeletePengguna(id);
            Console.WriteLine(sukses ? "Pengguna berhasil dihapus." : "Pengguna tidak ditemukan.");
            Console.ReadKey();
        }

        private void TampilkanSemuaPengguna()
        {
            Console.Clear();
            Console.WriteLine("--- Daftar Pengguna ---");

            var daftar = _penggunaService.GetAllPengguna();
            foreach (var p in daftar)
            {
                Console.WriteLine($"{p.IdPengguna} | {p.Username} | {p.Role} | {p.Fullname} | {p.Email}");
            }

            Console.ReadKey();
        }
    }
}