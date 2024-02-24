using AuthenAutherWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenAutherWebApp.Data
{
    public class AuthDbContext:IdentityDbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public AuthDbContext(DbContextOptions options):base(options)
        {
                   
        }
    }
}
