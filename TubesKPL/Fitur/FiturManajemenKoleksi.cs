using System;
using System.Collections.Generic;
using System.Linq;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturManajemenKoleksi
    {
        private readonly BukuService _bukuService;

        public FiturManajemenKoleksi()
        {
            _bukuService = new BukuService();
        }

        public ProgramState MenuManajemenKoleksi()
        {
            bool kembaliKeMenuUtama = false;

            while (!kembaliKeMenuUtama)
            {
                Console.Clear();
                Console.WriteLine("=== MANAJEMEN KOLEKSI ===");
                Console.WriteLine("1. Tambah Buku");
                Console.WriteLine("2. Hapus Buku");
                Console.WriteLine("3. Edit Buku");
                Console.WriteLine("4. Cari Buku");
                Console.WriteLine("5. Tampilkan Daftar Buku");
                Console.WriteLine("6. Kembali ke Menu Utama");
                Console.Write("Pilih Opsi: ");

                if (int.TryParse(Console.ReadLine(), out int pilihan))
                {
                    switch (pilihan)
                    {
                        case 1:
                            TambahBuku();
                            break;
                        case 2:
                            HapusBuku();
                            break;
                        case 3:
                            EditBuku();
                            break;
                        case 4:
                            CariBuku();
                            break;
                        case 5:
                            TampilkanDaftarBuku();
                            break;
                        case 6:
                            kembaliKeMenuUtama = true;
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
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
            return ProgramState.StateMenuUtama;
        }

        private void TambahBuku()
        {
            Console.Clear();
            Console.WriteLine("=== TAMBAH BUKU ===");

            try
            {
                Console.Write("Judul: ");
                string judul = Console.ReadLine();

                Console.Write("Pengarang: ");
                string penulis = Console.ReadLine();

                Console.Write("Penerbit: ");
                string penerbit = Console.ReadLine();

                Console.WriteLine("Kategori (1-Fiksi, 2-Non Fiksi, 3-Sains, 4-Sejarah): ");
                if (!Enum.TryParse(Console.ReadLine(), out Buku.KATEGORIBUKU kategori))
                {
                    Console.WriteLine("Kategori tidak valid. Menggunakan default Fiksi.");
                    kategori = Buku.KATEGORIBUKU.FIKSI;
                }

                Console.Write("Sinopsis: ");
                string sinopsis = Console.ReadLine();

                _bukuService.AddBuku(judul, penulis, penerbit, kategori, sinopsis);
                Console.WriteLine("\nBuku berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
            Console.ReadKey();
        }

        private void HapusBuku()
        {
            Console.Clear();
            Console.WriteLine("=== HAPUS BUKU ===");

            var semuaBuku = _bukuService.GetAllBuku();
            if (semuaBuku.Count == 0)
            {
                Console.WriteLine("Tidak ada buku dalam koleksi.");
                Console.ReadKey();
                return;
            }

            TampilkanDaftarBuku();
            Console.Write("\nMasukkan ID Buku yang ingin dihapus: ");
            string id = Console.ReadLine().ToUpper();

            var buku = _bukuService.GetBukuById(id);
            if (buku != null)
            {
                Console.WriteLine($"\nApakah anda yakin ingin menghapus buku: {buku.Judul}? (Y/N)");

                if (Console.ReadLine().ToUpper() == "Y")
                {
                    if (_bukuService.DeleteBuku(id))
                    {
                        Console.WriteLine("Buku berhasil dihapus!");
                    }
                    else
                    {
                        Console.WriteLine("Gagal menghapus buku");
                    }
                }
                else
                {
                    Console.WriteLine("Penghapusan dibatalkan");
                }
            }
            else
            {
                Console.WriteLine("ID buku tidak ditemukan");
            }

            Console.ReadKey();
        }

        private void EditBuku()
        {
            Console.Clear();
            Console.WriteLine("=== EDIT BUKU ===");

            var semuaBuku = _bukuService.GetAllBuku();
            if (semuaBuku.Count == 0)
            {
                Console.WriteLine("Tidak ada buku dalam koleksi");
                Console.ReadKey();
                return;
            }

            TampilkanDaftarBuku();
            Console.Write("\nMasukkan ID buku yang akan diedit: ");
            string id = Console.ReadLine().ToUpper();

            var buku = _bukuService.GetBukuById(id);
            if (buku != null)
            {
                try
                {
                    Console.WriteLine($"\nEdit data untuk: {buku.Judul}");

                    Console.Write("Judul baru (kosongkan jika tidak diubah): ");
                    string judul = Console.ReadLine();

                    Console.Write("Penulis baru: ");
                    string penulis = Console.ReadLine();

                    Console.Write("Penerbit baru: ");
                    string penerbit = Console.ReadLine();

                    Console.Write("Kategori baru (1-Fiksi, 2-Non Fiksi, 3-Sains, 4-Sejarah, kosongkan jika tidak diubah): ");
                    string kategoriInput = Console.ReadLine();
                    Buku.KATEGORIBUKU? kategori = null;
                    if (!string.IsNullOrEmpty(kategoriInput))
                    {
                        if (Enum.TryParse(kategoriInput, out Buku.KATEGORIBUKU parsedKategori))
                        {
                            kategori = parsedKategori;
                        }
                    }

                    Console.Write("Sinopsis baru: ");
                    string sinopsis = Console.ReadLine();

                    var updatedBuku = new Buku(
                        buku.IdBuku,
                        !string.IsNullOrEmpty(judul) ? judul : buku.Judul,
                        !string.IsNullOrEmpty(penulis) ? penulis : buku.Penulis,
                        !string.IsNullOrEmpty(penerbit) ? penerbit : buku.Penerbit,
                        kategori ?? buku.Kategori,
                        !string.IsNullOrEmpty(sinopsis) ? sinopsis : buku.Sinopsis
                    );

                    if (_bukuService.UpdateBuku(updatedBuku))
                    {
                        Console.WriteLine("\nBuku berhasil diperbarui!");
                    }
                    else
                    {
                        Console.WriteLine("\nGagal memperbarui buku.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Buku tidak ditemukan.");
                Console.ReadKey();
            }
        }

        private void CariBuku()
        {
            Console.Clear();
            Console.WriteLine("=== CARI BUKU ===");
            Console.WriteLine("1. Cari berdasarkan judul");
            Console.WriteLine("2. Cari berdasarkan penulis");
            Console.WriteLine("3. Cari berdasarkan penerbit");
            Console.WriteLine("4. Cari berdasarkan kategori");
            Console.Write("Pilih Metode pencarian: ");

            if (int.TryParse(Console.ReadLine(), out int metode) && metode >= 1 && metode <= 4)
            {
                Console.Write("Masukkan kata kunci: ");
                string keyword = Console.ReadLine().ToLower();

                var semuaBuku = _bukuService.GetAllBuku();
                List<Buku> hasilPencarian = new List<Buku>();

                switch (metode)
                {
                    case 1:
                        hasilPencarian = semuaBuku.Where(b => b.Judul.ToLower().Contains(keyword)).ToList();
                        break;
                    case 2:
                        hasilPencarian = semuaBuku.Where(b => b.Penulis.ToLower().Contains(keyword)).ToList();
                        break;
                    case 3:
                        hasilPencarian = semuaBuku.Where(b => b.Penerbit.ToLower().Contains(keyword)).ToList();
                        break;
                    case 4:
                        if (Enum.TryParse(keyword, true, out Buku.KATEGORIBUKU kategori))
                        {
                            hasilPencarian = semuaBuku.Where(b => b.Kategori == kategori).ToList();
                        }
                        else
                        {
                            Console.WriteLine("Kategori tidak valid.");
                        }
                        break;
                }

                if (hasilPencarian.Any())
                {
                    Console.WriteLine("\nHasil Pencarian:");
                    foreach (var buku in hasilPencarian)
                    {
                        Console.WriteLine($"ID: {buku.IdBuku} | Judul: {buku.Judul} | Penulis: {buku.Penulis} | Penerbit: {buku.Penerbit}");
                        Console.WriteLine($"Kategori: {buku.Kategori} | Status: {buku.Status} | Sinopsis: {buku.Sinopsis}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Tidak ditemukan buku yang sesuai.");
                }
            }
            else
            {
                Console.WriteLine("Metode pencarian tidak valid!");
            }

            Console.ReadKey();
        }

        private void TampilkanDaftarBuku()
        {
            Console.Clear();
            Console.WriteLine("=== DAFTAR BUKU ===");

            var semuaBuku = _bukuService.GetAllBuku();
            if (semuaBuku.Count == 0)
            {
                Console.WriteLine("Belum ada buku dalam koleksi");
            }
            else
            {
                foreach (var buku in semuaBuku)
                {
                    Console.WriteLine($"ID: {buku.IdBuku} | Judul: {buku.Judul} | Penulis: {buku.Penulis} | Penerbit: {buku.Penerbit}");
                    Console.WriteLine($"Kategori: {buku.Kategori} | Status: {buku.Status} | Sinopsis: {buku.Sinopsis}\n");
                }
            }
            Console.WriteLine("\nTekan sembarang tombol untuk melanjutkan...");
            Console.ReadKey();
        }
    }
}