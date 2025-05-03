using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using TubesKPL.Model;

namespace TubesKPL.Service
{
    internal class PenggunaService
    {
        List<Pengguna> listPengguna;

        public PenggunaService()
        {
            listPengguna = new List<Pengguna>();
        }

        public void AddPengguna(string userClass, string username, string password, Pengguna.ROLEPENGGUNA role, string fullname, string email, string phone, string address)
        {
            if (userClass == "Admin" || userClass == "Anggota")
            {
                string id = GeneratorIdPengguna(role);
                Pengguna newUser = new Pengguna(id, username, password, role, fullname, email, phone, address);
                listPengguna.Add(newUser);
            }
            else
            {
                Console.WriteLine("Invalid user class");
            }
        }

        public string GeneratorIdPengguna(Pengguna.ROLEPENGGUNA role)
        {
            string prefix = role == Pengguna.ROLEPENGGUNA.admin ? "A" : "P";

            var existingNumbers = new HashSet<int>();

            foreach (var pengguna in listPengguna)
            {
                if (pengguna.GetRole() == role &&
                    pengguna.GetId().StartsWith(prefix) &&
                    pengguna.GetId().Length == 4)
                {
                    if (int.TryParse(pengguna.GetId().Substring(1), out int num))
                    {
                        existingNumbers.Add(num);
                    }
                }
            }

            int newNumber = 1;
            while (existingNumbers.Contains(newNumber))
            {
                newNumber++;
            }

            return $"{prefix}{newNumber:D3}";
        }

        public List<Pengguna> GetAllPengguna()
        {
            return listPengguna;
        }

        public Pengguna GetPenggunaById(string id)
        {
            return listPengguna.FirstOrDefault(p => p.GetId() == id);
        }

        public bool DeletePengguna(string id)
        {
            var pengguna = GetPenggunaById(id);
            if (pengguna != null)
            {
                listPengguna.Remove(pengguna);
                return true;
            }
            return false;
        }

    }
}
