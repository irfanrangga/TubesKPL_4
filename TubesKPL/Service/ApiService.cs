using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpus.CLI.Service
{
    public class ApiService
    {
        public ApiService() { }
        public string Get(string endpoint)
        {
            // Simulate an API call
            return $"Response from {endpoint}";
        }
        public string Post(string endpoint, string data)
        {
            // Simulate an API call
            return $"Posted data to {endpoint}: {data}";
        }
        public string Put(string endpoint, string data)
        {
            // Simulate an API call
            return $"Updated data at {endpoint}: {data}";
        }
        public string Delete(string endpoint)
        {
            // Simulate an API call
            return $"Deleted data at {endpoint}";
        }

    }
}
