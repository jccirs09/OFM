using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace OFM.Models;
{
        public class Branch
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string? Address { get; set; }
            public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
            public ICollection<Truck> Trucks { get; set; } = new List<Truck>();
            public ICollection<Machine> Machines { get; set; } = new List<Machine>();
            public ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
        }
}