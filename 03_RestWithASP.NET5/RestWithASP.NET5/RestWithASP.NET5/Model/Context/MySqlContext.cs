using Microsoft.EntityFrameworkCore;

namespace RestWithASP.NET5.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() 
        {

        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options){}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
