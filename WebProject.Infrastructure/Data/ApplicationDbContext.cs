using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebProject.Infrastructure.Data.Common;
using WebProject.Infrastructure.Data.Identity;
using WebProject.Infrastructure.Data.TvSeries;

namespace WebProject.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Series> Seriess { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserSeries>()
                .HasKey(us => new { us.UserId, us.SeriesId });

            builder.Entity<GenreSeries>()
                .HasKey(gs => new { gs.SeriesId, gs.GenreId });

            base.OnModelCreating(builder);
        }
    }
}