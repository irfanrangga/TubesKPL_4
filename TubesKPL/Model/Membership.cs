using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpustakaan.Models
{
    public  class Membership
    {
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationDays { get; set; }

        public bool IsActive()
        {
            return DateTime.Now < StartDate.AddDays(DurationDays);
        }

    }
}
