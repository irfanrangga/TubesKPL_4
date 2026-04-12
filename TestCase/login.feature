Feature: Autentikasi Pengguna
  Sebagai anggota perpustakaan
  Saya ingin login ke sistem
  Agar bisa mengakses menu utama

  Scenario: Login berhasil sebagai anggota
    Given pengguna memasukkan username "Rija132"
    And pengguna memasukkan password "rijaganzz"
    When pengguna menekan tombol "Login"
    Then sistem menampilkan pesan "Selamat, anda telah berhasil login sebagai Anggota!"
    And halaman "MenuUtama" ditampilkan

  Scenario: Login gagal karena password salah
    Given pengguna memasukkan username "Rija132"
    And pengguna memasukkan password "salahpassword"
    When pengguna menekan tombol "Login"
    Then sistem menampilkan pesan "Login gagal, silakan login kembali!"
    And pengguna tetap berada di halaman login

  Scenario: Login gagal karena field kosong
    Given pengguna tidak mengisi username
    And pengguna tidak mengisi password
    When pengguna menekan tombol "Login"
    Then sistem menampilkan pesan "Isi username dan password terlebih dahulu."
    And pengguna tetap berada di halaman login
