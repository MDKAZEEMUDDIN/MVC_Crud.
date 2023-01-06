using Microsoft.EntityFrameworkCore;
using Student.Models;

namespace Student.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        } 
        public DbSet<Stddetail> Stddetails{ get; set; }    

    }
}
