using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
   public class MyContextInitialize : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            User user1 = new User() { Login = "admin", Password = "admin", IsClient = false };
            context.Users.Add(user1);
            context.SaveChanges();

            Collective collective1 = new Collective() { Name = "Stars" };
            Collective collective2 = new Collective() { Name = "Sky" };
            Collective collective3 = new Collective() { Name = "Black" };
            context.Collectives.Add(collective1);
            context.Collectives.Add(collective2);
            context.Collectives.Add(collective3);
            context.SaveChanges();

            Publisher p1 = new Publisher() { Name = "Publis", Country = "Ukraine" };
            Publisher p2 = new Publisher() { Name = "NewPublis", Country = "Ukraine" };
            context.Publishers.Add(p1);
            context.Publishers.Add(p2);
            context.SaveChanges();

            Genre g1 = new Genre() { Title = "Jazz" };
            Genre g2 = new Genre() { Title = "Pop" };
            Genre g3 = new Genre() { Title = "Disco" };
            context.Genres.Add(g1);
            context.Genres.Add(g2);
            context.Genres.Add(g3);
            context.SaveChanges();

            Disk d1 = new Disk()
            {
                Title = "Disk1",
                IdCollective = 1,
                IdPublisher = 1,
                CountSongs = 10,
                DtPublish = new System.DateTime(2020, 5, 5),
                Quantity = 55,
                Cost = 50,
                SellingPrice = 100,
                IsWriteOff = false
            };
            context.Disks.Add(d1);
            context.SaveChanges();
        }
    }
}
