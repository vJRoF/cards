using Microsoft.EntityFrameworkCore;

namespace Cards.DataAccess
{
    class AppContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=cards.db");
    }
}