using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ManajemenPerpustakaan.Config
{
    public class LibraryConfig
    {
        public int MaxBorrowBooks { get; set; }
        public int DefaultMembershipDurationDays { get; set; }

        public static LibraryConfig Load(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<LibraryConfig>(json);
        }
    }
}
