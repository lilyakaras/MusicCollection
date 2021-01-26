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
    public partial class AddCollectiveGenre : Form
    {
        string str;
        public AddCollectiveGenre()
        {
            InitializeComponent();
            str = "collective";
        }
        public AddCollectiveGenre(string s)
        {
            InitializeComponent();
            str = s;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (str == "collective")
            {
                using (MyDbContext context = new MyDbContext())
                {
                    Collective collec = new Collective() { Name = textBoxName.Text };
                    context.Collectives.Add(collec);
                    context.SaveChanges();
                }
            }
            else
            {
                if (str == "genre")
                {
                    using (MyDbContext context = new MyDbContext())
                    {
                        Genre collec = new Genre() { Title = textBoxName.Text };
                        context.Genres.Add(collec);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
