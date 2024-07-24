using AfaqMobileShop.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AfaqMobileShop.Server.Data
{
    public class AfaqMobileShopContext: DbContext
    {
        public AfaqMobileShopContext(DbContextOptions<AfaqMobileShopContext> options): base (options)
        {
            
        }

        public DbSet<Sell> Sales { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Buy> Buying { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().HasData(
                new Stock()
                {
                    Id = 1,
                    MobileName = "Infinix",
                    Quantity = 3,

                },
                new Stock()
                {
                     Id = 2,
                     MobileName = "realme",
                     Quantity = 5,

                },
                new Stock()
                {                                
                     Id = 3,                          
                     MobileName = "Techno",                                    
                     Quantity = 4,

                }
                );
            modelBuilder.Entity<Buy>().HasData(
                new Buy()
                {
                    Id = 1,
                    Name = "Khan",
                    FName = "Jan",
                    CNIC = "173743753773",
                    Adrss = "NSR",
                    IMEI1 = "s54646chghchfg",
                    IMEI2 = "no979879jh986",
                    Date = DateTime.Now,
                    MobileNumber = "03048034098",
                    MobileModel = "2020",
                    CNICPicture = new byte[] { 0, 1, 2, 3, 4, 5 },
                    Color = "red",
                    PurchasePrice = 2300,
                    Specs = "8gb 128gb"
                }
                );
            modelBuilder.Entity<User>().HasData(
                 new User()
                 {
                     Id = 1,
                     Name = "Admin",
                     UserName = "Admin",
                     Password = "Admin123"
                 }
                );
        }
/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sell>().HasData(
                new Sell()
                {
                    Id = 2,
                    Name = "Khan",
                    CNIC = "173743753773",
                    Address = "NSR",
                    IMEI1 = "s54646chghchfg",
                    IMEI2 = "no979879jh986",
                    SellDate = DateTime.Now,
                    Price = 30000,
                    Warranty = "1year",
                    Garranty = "2year",
                    Wasol = 20000,
                    Baqaya = 10000
                },
                              new Sell()
                              {
                                  Id = 3,
                                  Name = "Jan",
                                  CNIC = "173743753773",
                                  Address="NSR",
                                  IMEI1 = "s54646chghchfg",
                                  IMEI2 = "no979879jh986",
                                  SellDate = DateTime.Now,
                                  Price = 30000,
                                  Warranty = "1year",
                                  Garranty = "2year",
                                  Wasol = 20000,
                                  Baqaya = 10000
                              }
                );
        }*/
    }
}
