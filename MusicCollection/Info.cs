using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicCollection
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void buttonLatestNewDiscs_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var res = context.Disks.Where(x => x.DtPublish.Month == DateTime.Now.Month).ToList();
                try
                {
                    ResultsDiscs f9 = new ResultsDiscs(res);
                    f9.ShowDialog();
                }
                catch (Exception ex) { }
            }
        }

        private void buttonBestSellersMonth_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                try
                {

                    var BestSellersMonth = context.Sellings.AsEnumerable()
                         .Where(r => r.DateSell.Month == DateTime.Now.Month)
                         .GroupBy(r => r.IdDisk)
                         .OrderByDescending(g => g.Sum(r => r.Quantity))
                         .Select(g => g.First().IdDisk).ToList();
                    //.Take(3).ToList();
                    List<Disk> disks = new List<Disk>();
                    foreach (var item in context.Disks.ToList())
                    {
                        foreach (var item2 in BestSellersMonth)
                        {
                            if (item.IdDisk == item2)
                                disks.Add(item);
                        }
                    }
                    ResultsDiscs f9 = new ResultsDiscs(disks);
                    f9.ShowDialog();
                }
                catch (Exception ex) { }
            }
        }

        private void buttonBestSellersYear_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                try
                {
                    var BestSellersMonth = context.Sellings.AsEnumerable()
                         .Where(r => r.DateSell.Year == DateTime.Now.Year)
                         .GroupBy(r => r.IdDisk)
                         .OrderByDescending(g => g.Sum(r => r.Quantity))
                         .Select(g => g.First().IdDisk).ToList();
                    //.Take(3).ToList();

                    List<Disk> disks = new List<Disk>();
                    foreach (var item in context.Disks.ToList())
                    {
                        foreach (var item2 in BestSellersMonth)
                        {
                            if (item.IdDisk == item2)
                                disks.Add(item);
                        }
                    }
                    ResultsDiscs f9 = new ResultsDiscs(disks);
                    f9.ShowDialog();
                }
                catch (Exception ex) { }
            }
        }

        private void buttonMostPopularCollectiveMonth_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                try
                {
                    var PopularCollecMonth = context.Sellings.AsEnumerable()
                             .Where(r => r.DateSell.Month == DateTime.Now.Month)
                             .GroupBy(r => r.IdDisk)
                             .OrderByDescending(g => g.Sum(r => r.Quantity))
                             .Select(g => g.First().IdDisk).ToList();

                    List<Collective> collect = new List<Collective>();
                    foreach (var item in PopularCollecMonth)
                    {
                        foreach (var item2 in context.Disks.ToList())
                        {
                            if (item2.IdDisk == item)
                            {
                                Collective coll = context.Collectives.Where(x => x.IdCollective == item2.IdCollective).FirstOrDefault();
                                collect.Add(coll);
                            }
                        }
                    }
                    var res = collect.GroupBy(x => x.IdCollective);
                    int c = res.Count();
                    List<Collective> coll2 = new List<Collective>();
                    foreach (var key in res)
                    {
                        foreach (var item in key)
                        {
                            coll2.Add(item);
                            break;
                        }
                    }
                    ResultsDiscs f9 = new ResultsDiscs(coll2);
                    f9.ShowDialog();
                }
                catch (Exception ex) { }
            }
        }

        private void buttonMostPopularCollectiveYear_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                try
                {
                    var PopularCollecMonth = context.Sellings.AsEnumerable()
                             .Where(r => r.DateSell.Year == DateTime.Now.Year)
                             .GroupBy(r => r.IdDisk)
                             .OrderByDescending(g => g.Sum(r => r.Quantity))
                             .Select(g => g.First().IdDisk).ToList();

                    List<Collective> collect = new List<Collective>();
                    foreach (var item in PopularCollecMonth)
                    {
                        foreach (var item2 in context.Disks.ToList())
                        {
                            if (item2.IdDisk == item)
                            {
                                Collective coll = context.Collectives.Where(x => x.IdCollective == item2.IdCollective).FirstOrDefault();
                                collect.Add(coll);
                            }
                        }
                    }
                    var res = collect.GroupBy(x => x.IdCollective);
                    List<Collective> coll2 = new List<Collective>();
                    foreach (var key in res)
                    {
                        foreach (var item in key)
                        {
                            coll2.Add(item);
                            break;
                        }
                    }
                    ResultsDiscs f9 = new ResultsDiscs(coll2);
                    f9.ShowDialog();
                }
                catch (Exception ex) { }
            }
        }

        private void buttonMostPopularGenreMonth_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                try
                {
                    var PopularGenreMonth = context.Sellings.AsEnumerable()
                             .Where(r => r.DateSell.Month == DateTime.Now.Month)
                             .GroupBy(r => r.IdDisk)
                             .OrderByDescending(g => g.Sum(r => r.Quantity))
                             .Select(g => g.First().IdDisk).ToList();

                    List<Genre> genre1 = new List<Genre>();
                    foreach (var item in PopularGenreMonth)
                    {
                        foreach (var item2 in context.Disks.ToList())
                        {
                            if (item2.IdDisk == item)
                            {
                                foreach (var item3 in item2.Genres)
                                {
                                    Genre g = context.Genres.Where(x => x.IdGenre == item3.IdGenre).FirstOrDefault();
                                    genre1.Add(g);
                                }

                            }
                        }
                    }
                    var res = genre1.GroupBy(x => x.IdGenre);
                    List<Genre> coll2 = new List<Genre>();
                    foreach (var key in res)
                    {
                        foreach (var item in key)
                        {
                            coll2.Add(item);
                            break;
                        }
                    }
                    ResultsDiscs f9 = new ResultsDiscs(coll2);
                    f9.ShowDialog();
                }
                catch (Exception ex) { }

            }
        }

        private void buttonMostPopularGenreYear_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                try
                {
                    var PopularGenreMonth = context.Sellings.AsEnumerable()
                             .Where(r => r.DateSell.Year == DateTime.Now.Year)
                             .GroupBy(r => r.IdDisk)
                             .OrderByDescending(g => g.Sum(r => r.Quantity))
                             .Select(g => g.First().IdDisk).ToList();
                    List<Genre> genre1 = new List<Genre>();
                    foreach (var item in PopularGenreMonth)
                    {
                        foreach (var item2 in context.Disks.ToList())
                        {
                            if (item2.IdDisk == item)
                            {
                                foreach (var item3 in item2.Genres)
                                {
                                    Genre g = context.Genres.Where(x => x.IdGenre == item3.IdGenre).FirstOrDefault();
                                    genre1.Add(g);
                                }

                            }
                        }
                    }
                    var res = genre1.GroupBy(x => x.IdGenre);
                    List<Genre> coll2 = new List<Genre>();
                    foreach (var key in res)
                    {
                        foreach (var item in key)
                        {
                            coll2.Add(item);
                            break;
                        }
                    }
                    ResultsDiscs f9 = new ResultsDiscs(coll2);
                    f9.ShowDialog();
                }
                catch (Exception ex) { }
            }
        }
    }
}
