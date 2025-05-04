using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpus.Core.Models
{
    public class Pengguna
    {
        public enum ROLEPENGGUNA
        {
            admin,
            anggota
        }

        public string IdPengguna { get; set; } // Format ID: "YXXX" (Y = A untuk Admin OR P untuk pengguna, XXX = 3 digit angka unik)
        public string Username { get; set; }
        public string Password { get; set; }
        public ROLEPENGGUNA Role { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Pengguna(string idPengguna, string username, string password, ROLEPENGGUNA role, string fullname, string email, string phone, string address)
        {
            this.IdPengguna = idPengguna;
            this.Username = username;
            this.Password = password;
            this.Role = role;

            this.Fullname = fullname;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
        }
    }
}
