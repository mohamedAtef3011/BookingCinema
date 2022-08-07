using BookingCinema.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingCinema.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors_Movie>().HasKey(am => new {
                am.MoiveId,
                am.ActorId
            });
            modelBuilder.Entity<Actors_Movie>().HasOne<Movie>(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m=>m.MoiveId);
            modelBuilder.Entity<Actors_Movie>().HasOne<Actor>(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actors_Movie> Actors_Movies { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
