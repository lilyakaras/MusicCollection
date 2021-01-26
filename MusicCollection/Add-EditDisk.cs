using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicCollection
{
    public partial class Add_EditDisk : Form
    {
        Disk d1;
        public Add_EditDisk()
        {
            InitializeComponent();
            using (MyDbContext context = new MyDbContext())
            {
                foreach (var item in context.Collectives.ToList())
                {
                    comboBoxCollective.Items.Add(item);
                }
                foreach (var item in context.Publishers.ToList())
                {
                    comboBoxPublisher.Items.Add(item);
                }
            }
        }
        public Add_EditDisk(Disk d)
        {
            InitializeComponent();
            using (MyDbContext context = new MyDbContext())
            {
                foreach (var item in context.Collectives.ToList())
                {
                    comboBoxCollective.Items.Add(item);
                }
                foreach (var item in context.Publishers.ToList())
                {
                    comboBoxPublisher.Items.Add(item);
                }
                comboBoxCollective.SelectedItem = context.Collectives.Where(x => x.IdCollective == d.IdCollective).FirstOrDefault();
                comboBoxPublisher.SelectedItem = context.Publishers.Where(x => x.IdPublisher == d.IdPublisher).FirstOrDefault();
            }
            d1 = new Disk();
            d1 = d;
            textBoxTitle.Text = d.Title;
            textBoxCountSongs.Text = d.CountSongs.ToString();
            dateTimePickerDatePublish.Value = d.DtPublish;
            textBoxQuantity.Text = d.Quantity.ToString();
            textBoxCost.Text = d.Cost.ToString();
            textBoxSellingPrice.Text = d.SellingPrice.ToString();
            if (d.IsWriteOff == true)
                checkBoxIsWriteOff.Checked = true;
            else
                checkBoxIsWriteOff.Checked = false;

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.Text == "Add Disk")
            {
                try
                {
                    Disk disk1;
                    using (MyDbContext context = new MyDbContext())
                    {
                        Collective coll1 = comboBoxCollective.SelectedItem as Collective;
                        Publisher p1 = comboBoxPublisher.SelectedItem as Publisher;
                        bool IsWriteOff;
                        if (checkBoxIsWriteOff.Checked)
                            IsWriteOff = true;
                        else
                            IsWriteOff = false;

                        Disk newdisk = new Disk()
                        {
                            Title = textBoxTitle.Text,
                            IdCollective = coll1.IdCollective,
                            IdPublisher = p1.IdPublisher,
                            CountSongs = Convert.ToInt32(textBoxCountSongs.Text),
                            DtPublish = dateTimePickerDatePublish.Value,
                            Quantity = Convert.ToInt32(textBoxQuantity.Text),
                            Cost = Convert.ToInt32(textBoxCost.Text),
                            SellingPrice = Convert.ToInt32(textBoxSellingPrice.Text),
                            IsWriteOff = IsWriteOff
                        };
                        context.Disks.Add(newdisk);
                        context.SaveChanges();
                        disk1 = newdisk;
                    }
                    if (disk1 != null)
                    {
                        AddGenreToDisk f4 = new AddGenreToDisk(disk1);
                        f4.ShowDialog();
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("Data not correct"); }
            }
            else if (this.Text == "Update Disk")
            {
                try
                {
                    using (MyDbContext context = new MyDbContext())
                    {
                        var c1 = context.Disks.Where(x => x.IdDisk == d1.IdDisk).FirstOrDefault();
                        c1.Title = textBoxTitle.Text;
                        c1.IdCollective = (comboBoxCollective.SelectedItem as Collective).IdCollective;
                        c1.IdPublisher = (comboBoxPublisher.SelectedItem as Publisher).IdPublisher;
                        c1.CountSongs = Convert.ToInt32(textBoxCountSongs.Text);
                        c1.DtPublish = dateTimePickerDatePublish.Value;
                        c1.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                        c1.Cost = Convert.ToInt32(textBoxCost.Text);
                        c1.SellingPrice = Convert.ToInt32(textBoxSellingPrice.Text);
                        if (checkBoxIsWriteOff.Checked)
                            c1.IsWriteOff = true;
                        else
                            c1.IsWriteOff = false;
                        context.SaveChanges();

                    }
                }
                catch (Exception ex)
                { MessageBox.Show("Data not correct"); }
            }
        }

        private void textBoxTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[a-zA-Z0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxCountSongs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void buttonAddCollective_Click(object sender, EventArgs e)
        {
            AddCollectiveGenre form13 = new AddCollectiveGenre();
            form13.Text = "Add Collective";
            if (form13.ShowDialog() == DialogResult.OK)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    comboBoxCollective.Items.Clear();
                    foreach (var item in context.Collectives.ToList())
                    {
                        comboBoxCollective.Items.Add(item);
                    }
                    comboBoxCollective.SelectedIndex = (comboBoxCollective.Items.Count) - 1;
                }
            }
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            AddPublisher form14 = new AddPublisher();
            if (form14.ShowDialog() == DialogResult.OK)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    comboBoxPublisher.Items.Clear();
                    foreach (var item in context.Publishers.ToList())
                    {
                        comboBoxPublisher.Items.Add(item);
                    }
                    comboBoxPublisher.SelectedIndex = (comboBoxPublisher.Items.Count) - 1;
                }
            }
        }
    }
}
