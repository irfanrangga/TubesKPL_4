using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    internal class Pengguna
    {
        public enum ROLEPENGGUNA
        {
            admin,
            anggota
        }

        private string idPengguna;
        private string username;
        private string password;
        ROLEPENGGUNA role;

        private string fullname;
        private string email;
        private string phone;
        private string address;

        public Pengguna(string idPengguna, string username, string password, ROLEPENGGUNA role, string fullname, string email, string phone, string address)
        {
            this.idPengguna = idPengguna; // Format ID: "YXXX" (Y = A untuk Admin OR P untuk pengguna, XXX = 3 digit angka unik)
            this.username = username;
            this.password = password;
            this.role = role; 

            this.fullname = fullname;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        public string GetId() { return idPengguna; }

        public string GetUsername() { return username; }

        public string GetPassword() { return password; }

        public ROLEPENGGUNA GetRole() { return role; }

        public string GetFullName() { return fullname; }

        public string GetEmail() { return email; }

        public string GetPhone() { return phone; }

        public string GetAddress() { return address; }

        public void EditAccountData(string newUsername, string newPassword)
        {
            this.username = newUsername;
            this.password = newPassword;
        }

        public void EditUserData(string newFullname, string newEmail, string newPhone, string newAddress)
        {
            this.fullname = newFullname;
            this.email = newEmail;
            this.phone = newPhone;
            this.address = newAddress;
        }
    }
}
