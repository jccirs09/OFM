// Data/ApplicationUser.cs – extends IdentityUser to add branch assignment
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OFM.Models;
using System.Collections.Generic;
using System.Data;
using System.Reflection.PortableExecutable;
using static MudBlazor.Icons.Custom;

public class ApplicationUser : IdentityUser
{
    public int? BranchId { get; set; }
    public Branch? Branch { get; set; }
    public ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}

// Data/ApplicationDbContext.cs – the EF Core context
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OFM.Models;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Branch> Branches { get; set; } = default!;
    public DbSet<Role> Roles { get; set; } = default!;
    public DbSet<Truck> Trucks { get; set; } = default!;
    public DbSet<Machine> Machines { get; set; } = default!;
    public DbSet<SalesOrder> SalesOrders { get; set; } = default!;
    public DbSet<WorkOrder> WorkOrders { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Additional configuration if needed
    }
}
