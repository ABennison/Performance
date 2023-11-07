using DataSql.Classes;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DataSql
{
    public class DataContext : DbContext
    {
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<InstrumentType> InstrumentTypes { get; set; }



        public string DbPath = "";

        public DataContext()
        {
            //Get path to SQLite database file
            Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
            string path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "SQLite\\Performance.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}