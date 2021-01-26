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
    public partial class SearchDiscs : Form
    {
        public SearchDiscs()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioButtonTitle.Checked)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    try
                    {
                        var res = context.Disks.Where(x => x.Title == textBoxTitle.Text).ToList();
                        ResultsDiscs f9 = new ResultsDiscs(res);
                        f9.ShowDialog();
                    }
                    catch (Exception x) { }
                }
            }
            else
                 if (radioButtonCollective.Checked)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    try
                    {
                        var res = context.Disks.Where(x => x.Collective.Name == textBoxCollective.Text).ToList();
                        ResultsDiscs f9 = new ResultsDiscs(res);
                        f9.ShowDialog();
                    }
                    catch (Exception x) { }
                }
            }
            else
                 if (radioButtonGenre.Checked)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    try
                    {
                        var g = context.Genres.Where(z => z.Title == textBoxGenre.Text).FirstOrDefault();
                        var res = context.Genres.Select(x => x.Disks).ToList();
                        List<Disk> result = new List<Disk>();
                        foreach (var item in res)
                        {
                            foreach (var item2 in item)
                            {
                                if (item2.Genres.ToList().Contains(g) == true)
                                    result.Add(item2);
                            }
                        }

                        ResultsDiscs f9 = new ResultsDiscs(result);
                        f9.ShowDialog();
                    }
                    catch (Exception x) { }
                }
            }
        }
    }
}
