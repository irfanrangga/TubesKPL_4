//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TubesKPL.Model;

//namespace TubesKPL.Fitur
//{
//    internal class FiturNotifikasiOtomatis
//    {
//        public enum STATUSNOTIFIKASI
//        {
            
//        }

//        public string pesanPengingatPengembalian (string buku, string batas)
//        {
//            return $"Pengingat !\nBatas pengembalian buku {buku} adalah {batas}.";
//        }

//        public string pesanNotifikasiDenda(float denda, string buku, string batas)
//        {
//            return $"Pengingat !\nAnda terkena denda sebesar Rp.{denda} karena anda telat mengembalikan buku {buku} selama {batas} hari.";
//        }

//        public string pesanInformasiBukuBaru(string buku)
//        {
//            return $"Informasi !\nAda buku baru dengan judul {buku}";
//        }

//        public string pesanPemberitahuanStatusKeanggotaan(string nama, string status)
//        {
//            return $"Informasi !\nSelamat {nama}, dnda telah resmi menjadi anggota perpustakaan.";
//        }

//        //Otomatis generate semua notifikasi yang diperlukan
//        public void updateNotifikasi(Pengguna pengguna)
//        {
//            if (/*pengguna.pinjaman.batasPengembalian - DateTime.Now < 3*/ false) 
//            {
//                string pesan = pesanPengingatPengembalian(/*pengguna.pinjaman.judul , pengguna.pinjaman.batasPengembalian*/ "buku", "batas");
//            }

//            if (/*pengguna.pinjaman.batasPengembalian < DateTime.Now*/ false)
//            {
//                string pesan = pesanNotifikasiDenda(/*DateTime.Now - pengguna.pinjaman.batasPengembalian * 10000, pengguna.pinjaman.judul, pengguna.pinjaman.batasPengembalia*/ 0 , "buku", "batas");
//            }

//            if (/**/ false)

//        }


//    }
//}
