//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using ManajemenPerpustakaan.Config;
//using ManajemenPerpus.Core.Models;

//namespace ManajemenPerpustakaan.Services
//{
//    public class UserService
//    {
//        private List<User<Membership>> users = new();
//        private readonly LibraryConfig config;
//        private User<Membership>? currentUser;
//        private const string UsersFile = "users.json";

//        public UserService(LibraryConfig config)
//        {
//            this.config = config;
//            LoadUsers();
//        }

//        public void RegisterUser(string id, string name, string password, string role, string membershipType)
//        {
//            var membership = new Membership
//            {
//                Type = membershipType,
//                StartDate = DateTime.Now,
//                DurationDays = config.DefaultMembershipDurationDays
//            };
//            users.Add(new User<Membership>(id, name, password, role, membership));
//            SaveUsers();
//        }

//        public bool Login(string id, string password)
//        {
//            var user = users.FirstOrDefault(u => u.Id == id && u.Password == password);
//            if (user != null)
//            {
//                currentUser = user;
//                return true;
//            }
//            return false;
//        }

//        public string? GetCurrentRole() => currentUser?.Role;
//        public string? GetCurrentName() => currentUser?.Name;
//        public bool IsLoggedIn() => currentUser != null;

//        public List<User<Membership>> GetActiveUsers()
//        {
//            return users.Where(u => u.Membership.IsActive()).ToList();
//        }

//        private void LoadUsers()
//        {
//            if (File.Exists(UsersFile))
//            {
//                var json = File.ReadAllText(UsersFile);
//                users = JsonSerializer.Deserialize<List<User<Membership>>>(json) ?? new();
//            }
//        }

//        private void SaveUsers()
//        {
//            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
//            File.WriteAllText(UsersFile, json);
//        }
//    }
//}
