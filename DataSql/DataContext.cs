using Microsoft.EntityFrameworkCore;

namespace DataSql
{
    public class DataContext : DbContext
    {
        public string DbPath = "";

        public DataContext()
        {
            //Get path to SQLite database file
            Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
            string path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "SQLite/Performance.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}