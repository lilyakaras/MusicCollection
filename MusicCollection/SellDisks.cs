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
    public partial class SellDisks : Form
    {
        public Disk Disk1 { get; set; }
        public SellDisks()
        {
            InitializeComponent();
        }
        public SellDisks(Disk disk)
        {
            InitializeComponent();
            Disk1 = new Disk();
            Disk1 = disk;
            textBoxDisk.Text = disk.Title;
            textBoxInStock.Text = disk.Quantity.ToString();
            textBoxPrice.Text = disk.SellingPrice.ToString();
            using (MyDbContext context = new MyDbContext())
            {
                foreach (var item in context.Users.ToList())
                {
                    if (item.IsClient == true)
                        comboBoxClient.Items.Add(item);
                }
            }
            textBoxDiscount.Text = "0";
            using (MyDbContext context = new MyDbContext())
            {
                try
                {
                    System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@idDisk", Disk1.IdDisk);
                    int discount1 = context.Database.SqlQuery<int>("SELECT dbo.fnGetSale(@idDisk)", param).Single();
                    textBoxDiscount.Text = discount1.ToString();
                }
                catch (Exception ex) { }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                using (MyDbContext context = new MyDbContext())
                {
                    Selling selling1 = new Selling();
                    selling1.IdDisk = Disk1.IdDisk;
                    selling1.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                    selling1.Price = Convert.ToInt32(textBoxPrice.Text);
                    selling1.DateSell = dateTimePickerDateSell.Value;
                    selling1.IdUser = (comboBoxClient.SelectedItem as User).IdUser;
                    context.Sellings.Add(selling1);
                    context.SaveChanges();
                }
            }
            catch (Exception exx)
            { MessageBox.Show("Not enough disks in stock"); }
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            User u1 = comboBoxClient.SelectedItem as User;
            if (u1 != null)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    int x = 0;
                    if (textBoxDiscount.Text != "0")
                        x = Convert.ToInt32(textBoxDiscount.Text);//попередні акції місяця
                    try
                    {
                        System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@idUser", u1.IdUser);
                        int sumAll = context.Database.SqlQuery<int>("SELECT dbo.fnGetSum(@idUser)", param).Single();
                        if (x != 0)
                        {
                            if (sumAll > 500 && sumAll < 1000)//знижки по сумі клієнта + акції тижня(місяця)
                                textBoxDiscount.Text = (3 + x).ToString();
                            else
                                if (sumAll > 1000 && sumAll < 2000)
                                textBoxDiscount.Text = (5 + x).ToString();
                            else
                                if (sumAll > 2000 && sumAll < 5000)
                                textBoxDiscount.Text = (10 + x).ToString();
                            else
                                if (sumAll > 5000)
                                textBoxDiscount.Text = (15 + x).ToString();

                        }
                        else
                        {
                            if (sumAll > 500 && sumAll < 1000)//суто по сумі клієнта знижки
                                textBoxDiscount.Text = "3";
                            else
                                 if (sumAll > 1000 && sumAll < 2000)
                                textBoxDiscount.Text = "5";
                            else
                                 if (sumAll > 2000 && sumAll < 5000)
                                textBoxDiscount.Text = "10";
                            else
                                 if (sumAll > 5000)
                                textBoxDiscount.Text = "15";
                            else
                                textBoxDiscount.Text = "0";
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            int sum1, total;
            if (textBoxDiscount.Text != "0")
            {
                sum1 = (((Convert.ToInt32(textBoxQuantity.Text)) * (Convert.ToInt32(textBoxPrice.Text))) * (Convert.ToInt32(textBoxDiscount.Text))) / 100;
                total = ((Convert.ToInt32(textBoxQuantity.Text)) * (Convert.ToInt32(textBoxPrice.Text))) - sum1;
            }
            else
                total = ((Convert.ToInt32(textBoxQuantity.Text)) * (Convert.ToInt32(textBoxPrice.Text)));

            textBoxTotallSum.Text = total.ToString();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser f11 = new AddUser();
            f11.Text = "Add User";
            if (f11.ShowDialog() == DialogResult.OK)
            {
                comboBoxClient.Items.Clear();
                using (MyDbContext context = new MyDbContext())
                {
                    foreach (var item in context.Users.ToList())
                    {
                        if (item.IsClient == true)
                            comboBoxClient.Items.Add(item);
                    }
                    comboBoxClient.SelectedIndex = (comboBoxClient.Items.Count) - 1;
                }
            }
        }
    }
}
