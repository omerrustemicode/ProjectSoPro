
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSoPro.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> person { get; set; }
        public DbSet<Movie> movie { get; set; }
        public DbSet<Genre> genre { get; set; }
        public DbSet<PersonRoles> roles { get; set; }
        public DbSet<MovieRoles> movieRoles { get; set; }

    }
}
