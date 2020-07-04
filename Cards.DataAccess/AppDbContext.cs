using Cards.DataAccess.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Cards.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .HasData(
                    new Card{ Id = 10000, DeckName = Decks.Sample, PictureUri = Utils.MakeGoogleDriveExportUri("1X1ChJjhZkvnBGP4De8Gf5MnsHleaT6Qy") },
                    new Card { Id = 1, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    new Card { Id = 2, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1B-m9CUp43S1ElqrzdnLQFR2rrg4pOzlI") },
                    new Card { Id = 3, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1mHeIWMuxQnZ2qifSZxSAmoY3xPU8vV3s") },
                    new Card { Id = 4, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1nt2QxOc7Sr5srHbhI1ITKVPOt3vwhYQh") });
                    //new Card { Id = 5, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 6, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 7, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 8, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 9, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 10, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 11, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 12, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 13, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 14, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 15, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 16, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 17, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 18, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 19, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 20, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 21, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 22, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 23, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 24, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 25, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 26, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 27, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 28, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 29, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 30, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 31, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 32, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 33, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 34, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 35, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 36, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 37, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 38, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 39, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 40, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 41, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") },
                    //new Card { Id = 42, DeckName = Decks.Deck1, PictureUri = Utils.MakeGoogleDriveExportUri("1Fhs5PgE7J77FEMl8ZJiupHkVUimUQ4P3") });

            modelBuilder.Entity<User>()
                .HasData(new User { Id = 1, Name = "MisterVovan"});
                

            base.OnModelCreating(modelBuilder);
        }
    }
}