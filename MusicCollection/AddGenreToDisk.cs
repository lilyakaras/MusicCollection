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
    public partial class AddGenreToDisk : Form
    {
        
        public AddGenreToDisk(Disk disk)
        {
            InitializeComponent();
            using (MyDbContext context = new MyDbContext())
            {
                comboBoxIdDisk.Items.Add(disk);
                comboBoxIdDisk.SelectedIndex = 0;

                foreach (var item in context.Genres.ToList())
                {
                    comboBoxIdGenre.Items.Add(item);
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                Disk d1 = comboBoxIdDisk.SelectedItem as Disk;
                Genre g1 = comboBoxIdGenre.SelectedItem as Genre;
                var disk1 = context.Disks.Where(x => x.IdDisk == d1.IdDisk).FirstOrDefault();
                var genre1 = context.Genres.Where(x => x.IdGenre == g1.IdGenre).FirstOrDefault();
                disk1.Genres.Add(genre1);
                context.SaveChanges();
            }
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            AddCollectiveGenre form13 = new AddCollectiveGenre("genre");
            form13.Text = "Add Genre";
            if (form13.ShowDialog() == DialogResult.OK)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    comboBoxIdGenre.Items.Clear();
                    foreach (var item in context.Genres.ToList())
                    {
                        comboBoxIdGenre.Items.Add(item);
                    }
                    comboBoxIdGenre.SelectedIndex = comboBoxIdGenre.Items.Count - 1;
                }
            }
        }
    }
}
