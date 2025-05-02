using System;
using TubesKPL.Model;
using TubesKPL.Service;

class Program
{
    static void Main()
    {
        Console.WriteLine("Testing PenggunaService");
        TestPenggunaService();

        Console.WriteLine("\nTesting BukuService");
        TestBukuService();
    }

    static void TestPenggunaService()
    {
        var penggunaService = new PenggunaService();

        Console.WriteLine("\nAddPengguna");
        penggunaService.AddPengguna("Admin", "budi", "budi123", Pengguna.ROLEPENGGUNA.admin, "budima", "budi@email.com", "081211112222", "Bandung");
        penggunaService.AddPengguna("Admin", "joko", "joko123", Pengguna.ROLEPENGGUNA.admin, "jokowi", "joko@email.com", "081222221111", "Jakarta");
        penggunaService.AddPengguna("Anggota", "ahmad", "ahmad123", Pengguna.ROLEPENGGUNA.anggota, "ahmadani", "ahmad@email.com", "081211221122", "Bogor");
        penggunaService.AddPengguna("Anggota", "ari", "ari123", Pengguna.ROLEPENGGUNA.anggota, "arilasso", "ari@email.com", "081222112211", "Jakarta");

        Console.WriteLine("\nGetAllPengguna");
        var allPengguna = penggunaService.GetAllPengguna();
        foreach (var p in allPengguna)
        {
            Console.WriteLine($"{p.GetId()}: {p.GetUsername()}");
        }

        Console.WriteLine("\nGetPenggunaById");
        var pengguna = penggunaService.GetPenggunaById("A001");
        Console.WriteLine(pengguna != null
            ? $"Found: {pengguna.GetUsername()}"
            : "Not found");

        Console.WriteLine("\nDeletePengguna");
        bool deleted = penggunaService.DeletePengguna("A001");
        Console.WriteLine(deleted ? "Successfully deleted A001" : "Delete failed");

        Console.WriteLine("\nGetAllPengguna");
        allPengguna = penggunaService.GetAllPengguna();
        foreach (var p in allPengguna)
        {
            Console.WriteLine($"{p.GetId()}: {p.GetUsername()}");
        }
    }

    static void TestBukuService()
    {
        var bukuService = new BukuService();
        Console.WriteLine("\nAddBuku");
        bukuService.AddBuku("Laut Bercerita", "Leila S Chudori", "Gramedia", Buku.KATEGORIBUKU.FIKSI, "Novel tentang perjuangan dan kehilangan");
        bukuService.AddBuku("Norwegian Wood", "Haruki Murakami", "Gramedia", Buku.KATEGORIBUKU.FIKSI, "Kisah cinta dan kedewasaan di Tokyo");
        bukuService.AddBuku("Cantik Itu Luka", "Eka Kurniawan", "Gramedia", Buku.KATEGORIBUKU.FIKSI, "Novel magis-realisme tentang perempuan kuat");
        bukuService.AddBuku("Atomic Habits", "James Clear", "Gramedia", Buku.KATEGORIBUKU.NONFIKSI, "Membangun kebiasaan baik dan menghilangkan yang buruk");
        bukuService.AddBuku("Bicara Itu Ada Seninya", "Oh Su Hyang", "Bentang Pustaka", Buku.KATEGORIBUKU.NONFIKSI, "Seni berkomunikasi efektif");
        bukuService.AddBuku("Berani Tidak Disukai", "Ichiro Kishimi & Fumitake Koga", "Gramedia", Buku.KATEGORIBUKU.NONFIKSI, "Mengubah hidup dengan filosofi Adler");

        Console.WriteLine("\nGetAllBuku");
        var allBuku = bukuService.GetAllBuku();
        foreach (var b in allBuku)
        {
            Console.WriteLine($"{b.GetIdBuku()}: {b.GetJudul()} ({b.GetKategori()})");
        }

        Console.WriteLine("\nGetBukuById");
        var buku = bukuService.GetBukuById("B001");
        Console.WriteLine(buku != null
            ? $"Found: {buku.GetJudul()}"
            : "Not found");

        Console.WriteLine("\nDeleteBuku");
        bool deleted = bukuService.DeleteBuku("B001");
        Console.WriteLine(deleted ? "Successfully deleted B001" : "Delete failed");

        Console.WriteLine("\nGetAllBuku");
        allBuku = bukuService.GetAllBuku();
        foreach (var b in allBuku)
        {
            Console.WriteLine($"{b.GetIdBuku()}: {b.GetJudul()}");
        }
    }
}