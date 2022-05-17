using Microsoft.EntityFrameworkCore;



namespace MovieApplication.Models
{
    public partial class MovieStoreDBContext : DbContext
    {


        public MovieStoreDBContext(DbContextOptions<MovieStoreDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server-localhost;Database-Newmdb;Trusted_Connection-True;");
            }
        }


    }
}
