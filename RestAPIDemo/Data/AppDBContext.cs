using Microsoft.EntityFrameworkCore;
using RestAPIDemo.Model;

namespace RestAPIDemo.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {



        }

        public DbSet<Movie> movieDbSet { get; set;}
}
}
