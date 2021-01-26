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
    public partial class AddDiscount : Form
    {
        public AddDiscount()
        {
            InitializeComponent();
            using (MyDbContext context = new MyDbContext())
            {
                foreach (var item in context.Disks.ToList())
                {
                    comboBoxClient.Items.Add(item);
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                Discount discount = new Discount();
                discount.Title = textBoxTitle.Text;
                discount.Percent = Convert.ToInt32(textBoxPercent.Text);
                discount.IdDisk = (comboBoxClient.SelectedItem as Disk).IdDisk;
                discount.DtStart = dateTimePickerDtStart.Value;
                discount.DtEnd = dateTimePickerDtEnd.Value;
                context.Discounts.Add(discount);
                context.SaveChanges();
            }
        }
    }
}
