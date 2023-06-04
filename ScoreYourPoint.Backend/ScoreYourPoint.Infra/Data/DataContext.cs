using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ScoreYourPointApi.Domain;
using ScoreYourPointAPI.Domain;

namespace ScoreYourPointApi.Infra.Data
{

    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("ScoreYourPointApiDatabase"), b => b.MigrationsAssembly("ScoreYourPoint.Api"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfileRating> ProfileRatings { get; set; }

        public DbSet<Sport> Sports { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<SportPosition> SportPositions { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventPositionRestriction> EventPositionRestrictions { get; set; }
        public DbSet<UserEventParticipation> UserEventParticipations { get; set; }

    }
}