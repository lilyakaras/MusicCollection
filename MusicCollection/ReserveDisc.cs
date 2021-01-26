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
    public partial class ReserveDisc : Form
    {
        public ReserveDisc()
        {
            InitializeComponent();
            using (MyDbContext context = new MyDbContext())
            {
                foreach (var item in context.Disks.ToList())
                {
                    comboBoxReserveDisc.Items.Add(item);
                }
                foreach (var item in context.Users.ToList())
                {
                    if (item.IsClient == true)
                        comboBoxUser.Items.Add(item);
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Disk d1 = comboBoxReserveDisc.SelectedItem as Disk;
            User u1 = comboBoxUser.SelectedItem as User;
            ReserveDisks reserveDisks = new ReserveDisks() { IdDisk = d1.IdDisk, IdUser = u1.IdUser };
            using (MyDbContext context = new MyDbContext())
            {
                context.ReserveDiskss.Add(reserveDisks);
                context.SaveChanges();

                var res = context.Disks.Where(x => x.IdDisk == d1.IdDisk).FirstOrDefault();
                res.Quantity -= 1;
                context.SaveChanges();

            }
        }
    }
}
