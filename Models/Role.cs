
namespace OFM.Models;
{
    public class Role
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string? Description { get; set; }
            public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
        }
}