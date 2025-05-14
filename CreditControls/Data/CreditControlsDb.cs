using CreditControls.Models;
using Microsoft.EntityFrameworkCore;

namespace CreditControls.Data
{
    public class CreditControlsDb : DbContext
    {
        public CreditControlsDb(DbContextOptions<CreditControlsDb> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Merchant> Merchants { get; set; }

    }    
}
