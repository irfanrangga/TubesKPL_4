﻿using System;
using ManajemenPerpus.CLI.Fitur;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.CLI
{
    public enum ProgramState
    {
        StateMenuUtama,
        StateManajemenPengguna,
        StateManajemenKoleksi,
        StateManajemenBuku,
        StateSirkulasiBuku,
        StateUlasanRekomendasi,
        StateLaporanStatistik,
        StateNotifikasiOtomatis,
        StateKeluar
    }

    class Program
    {

        static ProgramState currentState = ProgramState.StateMenuUtama;

        static void Main(string[] args)
        {
            var bukuService = new BukuService();
            var pinjamanService = new PinjamanService();
            var dendaService = new DendaService();
            var penggunaService = new PenggunaService();

            var fiturManajemenPengguna = new FiturManajemenPengguna();
            var fiturManajemenBuku = new FiturManajemenBuku();
            var fiturSirkulasiBuku = new FiturSirkulasiBuku();
            var fiturUlasanRekomendasi = new FiturUlasanRekomendasi();
            var fiturLaporanStatistik = new FiturLaporanStatistik(bukuService, pinjamanService, dendaService, penggunaService);
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
                    case ProgramState.StateManajemenBuku:
                        currentState = fiturManajemenBuku.MenuManajemenBuku();
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