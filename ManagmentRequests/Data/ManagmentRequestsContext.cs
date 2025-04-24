using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManagmentRequests.Components.Models;

namespace ManagmentRequests.Data
{
    public class ManagmentRequestsContext : DbContext
    {
        public ManagmentRequestsContext (DbContextOptions<ManagmentRequestsContext> options)
            : base(options)
        {
        }

        public DbSet<ManagmentRequests.Components.Models.Part> Parts { get; set; } = default!;
        public DbSet<ManagmentRequests.Components.Models.Technician> Technicians { get; set; } = default!;
        public DbSet<ManagmentRequests.Components.Models.Building> Buildings { get; set; } = default!;
        public DbSet<ManagmentRequests.Components.Models.Elevator> Elevators { get; set; } = default!;
        public DbSet<ManagmentRequests.Components.Models.ServiceRequestcs> ServiceRequestcss { get; set; } = default!;
    }
}
