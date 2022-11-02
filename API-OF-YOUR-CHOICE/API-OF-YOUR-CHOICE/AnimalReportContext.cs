using API_OF_YOUR_CHOICE.Models.Fall2022_Class_of_your_choice;
using Microsoft.EntityFrameworkCore;

namespace API_OF_YOUR_CHOICE
{
    public class AnimalReportContext : DbContext
    {
        public DbSet<AnimalReport> AnimalReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ARC;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<AnimalReport>().HasData(
                    new AnimalReport() { Id = 1, Animal = "Deer", Spottings = 100},
                    new AnimalReport() { Id = 2, Animal = "Turkey", Spottings = 45},
                    new AnimalReport() { Id = 3, Animal = "Duck", Spottings = 1000},
                    new AnimalReport() { Id = 4, Animal = "Bear", Spottings = 21},
                    new AnimalReport() { Id = 5, Animal = "Elk",Spottings = 2});
        }
    }
}
