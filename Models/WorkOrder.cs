using System;
using System.ComponentModel.DataAnnotations;
using OFM.Data;

namespace OFM.Models
{
    public class WorkOrder
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string WorkOrderNumber { get; set; } = string.Empty;
        public int SalesOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; } = default!;
        public DateTime ScheduledDate { get; set; }
        public string? Description { get; set; }
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }
        public int? TruckId { get; set; }
        public Truck? Truck { get; set; }
        public int? MachineId { get; set; }
        public Machine? Machine { get; set; }
        public string? AssignedUserId { get; set; }
        public ApplicationUser? AssignedUser { get; set; }
        public string? Status { get; set; }
    }
}
