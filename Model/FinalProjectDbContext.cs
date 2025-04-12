using Microsoft.EntityFrameworkCore;
using Model.DomainModels;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Model
{
    public class FinalProjectDbContext:DbContext
    {
        public FinalProjectDbContext(DbContextOptions options) :base(options)
        {

        }
        public FinalProjectDbContext()
        { 

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = FinalProjectDb; Integrated Security = True;MultipleActiveResultSets=true;Encrypt=False;");
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product{ get; set; }
    }
}
