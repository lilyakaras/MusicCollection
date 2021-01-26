using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
  public  class MyDbContext : DbContext
    {
        static MyDbContext()//для ініціалізатора, створення адміна
        {
            Database.SetInitializer<MyDbContext>(new MyContextInitialize());
        }
        public MyDbContext() : base("conString")
        { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Collective> Collectives { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Disk> Disks { get; set; }
        public virtual DbSet<Selling> Sellings { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<ReserveDisks> ReserveDiskss { get; set; }
    }
}
