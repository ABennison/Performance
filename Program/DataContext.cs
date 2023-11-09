using Microsoft.EntityFrameworkCore;
using PnLCalculator.Classes;

namespace PnLCalculator
{
    public class DataContext : DbContext
    {
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<InstrumentType> InstrumentTypes { get; set; }
        public DbSet<MarketPrice> MarketPrices { get; set; }
        public DbSet<Position> Positions { get; set; }



        public string DbPath = "";

        public DataContext()
        {
            DbPath = Path.Join(Directory.GetCurrentDirectory(), "Performance.db");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}