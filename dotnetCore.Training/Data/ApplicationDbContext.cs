using dotnetCore.Training.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetCore.Training.Data
{
    //Database
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        //Tables
        public DbSet<Student> Students { get; set; }
    }
}
