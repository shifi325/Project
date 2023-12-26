using Blood_Bank.Core.Entities;
using Blood_Bank.Data;
using Microsoft.EntityFrameworkCore;

namespace Blood_Bank.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Donors> DonorsList { get; set; }
        public DbSet<Donations> DonationsList { get; set; }
        public DbSet<Sicks> SicksList { get; set; }
        //public DataContext()
        //{
        //    DonorsList = new DbSet<Donors>();
        //    DonorsList.Add(new Donors { idDonor = 1, fNameDonor = "shifi", lNameDonor = "weingarten", typeBloodDonor = "A", pelephoneDonor = "0556773857", statusDonor = 1 });
        //    DonationsList = new DbSet<Donations>();
        //    DonationsList.Add(new Donations { idDonation = 2, idDonor =1 ,idSick=3,statusDonation=2 });
        //    SicksList = new DbSet<Sicks>();
        //    SicksList.Add(new Sicks { idSick = 1, fNameSick = "shifi", lNameSick = "weingarten", typeBloodSick = "A", pelephoneSick = "0556773857", statusSick = 1 });

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Blood_Bank_db");
        }
    }
}
