using System;
using ManajemenPerpus.CLI.Fitur;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using ManajemenPerpus.Core.Models;

namespace ManajemenPerpus.CLI
{
    public class Program
    {
        private List<Pengguna> pengguna = new List<Pengguna>();
        private List<Buku> buku = new List<Buku>();
        private List<Pinjaman> pinjaman = new List<Pinjaman>();
        private List<Ulasan> ulasan = new List<Ulasan>();
        private List<Notifikasi> notifikasi = new List<Notifikasi>();
        private List<Denda> denda = new List<Denda>();

        public enum ProgramState
        {
            StateMenuUtama,
            StateManajemenPengguna,
            StateManajemenKoleksi,
            StateSirkulasiBuku,
            StateUlasanRekomendasi,
            StateLaporanStatistik,
            StateNotifikasiOtomatis,
            StateKeluar
        }

       public static ProgramState currentState = ProgramState.StateMenuUtama;

       public static void Main(string[] args)
        {
            var fiturManajemenPengguna = new FiturManajemenPengguna();
            var fiturManajemenKoleksi = new FiturManajemenKoleksi();
            var fiturSirkulasiBuku = new FiturSirkulasiBuku();
            var fiturUlasanRekomendasi = new FiturUlasanRekomendasi();
            var fiturLaporanStatistik = new FiturLaporanStatistik();
            var fiturNotifikasiOtomatis = new FiturNotifikasiOtomatis();

            while (currentState != ProgramState.StateKeluar)
            {
                switch (currentState)
                {
                    case ProgramState.StateMenuUtama:
                        currentState = Menu.MenuUtama();
                        break;
                    case ProgramState.StateManajemenPengguna:
                        currentState = fiturManajemenPengguna.MenuManajemenPengguna();
                        break;
                    case ProgramState.StateManajemenKoleksi:
                        currentState = fiturManajemenKoleksi.MenuManajemenKoleksi();
                        break;
                    case ProgramState.StateSirkulasiBuku:
                        currentState = fiturSirkulasiBuku.MenuSirkulasiBuku();
                        break;
                    case ProgramState.StateUlasanRekomendasi:
                        currentState = fiturUlasanRekomendasi.MenuUlasanRekomendasi();
                        break;
                    case ProgramState.StateLaporanStatistik:
                        currentState = fiturLaporanStatistik.MenuLaporanStatistik();
                        break;
                    case ProgramState.StateNotifikasiOtomatis:
                        currentState = fiturNotifikasiOtomatis.MenuNotifikasiOtomatis();
                        break;
                }
            }
        }
    }
}

