using Microsoft.EntityFrameworkCore;

namespace Cards.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .HasData(new Card{ Id = 1, DeckName = "Sample", PictureUri = Utils.MakeGoogleDriveExportUri("1X1ChJjhZkvnBGP4De8Gf5MnsHleaT6Qy") });

            base.OnModelCreating(modelBuilder);
        }
    }
}