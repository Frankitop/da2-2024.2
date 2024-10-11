using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class MovieContext : DbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public MovieContext() { }

        public MovieContext(DbContextOptions options) : base(options) { }
    }
}
