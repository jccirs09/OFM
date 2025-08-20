using Microsoft.Data.SqlClient;

namespace OFM.Models;
{
    public class Machine
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }
        public ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
    }
}