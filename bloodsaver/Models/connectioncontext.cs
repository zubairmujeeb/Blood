using System.Data.Entity;

namespace bloodsaver.Models
{

    public class connectioncontext : DbContext
    {
        public DbSet<registration> employess { get; set; }
        public DbSet<countrys> allcountry { get; set; }
        public DbSet<citys> allcities { get; set; }

        //  public DbSet<Mail> mail { get; set; }
        //  public DbSet<retriving> al { get; set; }


    }

}