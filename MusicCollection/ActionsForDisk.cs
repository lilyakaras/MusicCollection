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
    public partial class ActionsForDisk : Form
    {
        public ActionsForDisk()
        {
            InitializeComponent();
        }

        private void buttonAddDisk_Click(object sender, EventArgs e)
        {
            Add_EditDisk form3 = new Add_EditDisk();
            form3.Text = "Add Disk";
            DialogResult res = form3.ShowDialog();
            if (res == DialogResult.OK)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    bindingSource1.DataSource = context.Disks.ToList();
                    dataGridView1.DataSource = bindingSource1;
                }
            }
            else
            { MessageBox.Show("Not added"); }
        }

        private void buttonEditDisk_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Disk s = new Disk();
                s = dataGridView1.CurrentRow.DataBoundItem as Disk;
                Add_EditDisk f3 = new Add_EditDisk(s);
                f3.Text = "Update Disk";
                DialogResult res = f3.ShowDialog();
                if (res == DialogResult.OK)
                {
                    using (MyDbContext context = new MyDbContext())
                    {
                        bindingSource1.DataSource = context.Disks.ToList();
                        dataGridView1.DataSource = bindingSource1;
                    }
                }
            }
        }

        private void buttonDeleteDisk_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdDisk"].Value.ToString());
                    var s1 = context.Disks.Where(x => x.IdDisk == id).FirstOrDefault();
                    context.Disks.Remove(s1);
                    context.SaveChanges();
                    bindingSource1.DataSource = context.Disks.ToList();
                    dataGridView1.DataSource = bindingSource1;
                }
            }
        }

        private void buttonSearchDisk_Click(object sender, EventArgs e)
        {
            SearchDiscs f8 = new SearchDiscs();
            f8.ShowDialog();
        }

        private void buttonShowAllDisks_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                bindingSource1.DataSource = context.Disks.ToList();
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.Columns["Collective"].Visible = false;
                dataGridView1.Columns["Publisher"].Visible = false;
                dataGridView1.Columns["Genres"].Visible = false;
            }
        }

        private void buttonSellDisk_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Disk disk1 = new Disk();
                disk1 = dataGridView1.CurrentRow.DataBoundItem as Disk;
                if (disk1.IsWriteOff == true)
                { MessageBox.Show("Disk written off. Impossible to sell"); }
                else
                {
                    try
                    {
                        SellDisks form5 = new SellDisks(disk1);
                        DialogResult res = form5.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            using (MyDbContext context = new MyDbContext())
                            {
                                bindingSource1.DataSource = context.Disks.ToList();
                                dataGridView1.DataSource = bindingSource1;
                            }
                        }
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Not correct"); }
                }
            }
        }

        private void buttonWriteOffDisk_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdDisk"].Value.ToString());
                    var s1 = context.Disks.Where(x => x.IdDisk == id).FirstOrDefault();
                    s1.IsWriteOff = true;
                    context.SaveChanges();
                    bindingSource1.DataSource = context.Disks.ToList();
                    dataGridView1.DataSource = bindingSource1;
                }
            }
        }

        private void buttonAddDiscount_Click(object sender, EventArgs e)
        {
            AddDiscount f6 = new AddDiscount();
            f6.ShowDialog();
        }

        private void buttonReserveDisk_Click(object sender, EventArgs e)
        {
            ReserveDisc f7 = new ReserveDisc();
            f7.ShowDialog();
        }

        private void buttonModificateData_Click(object sender, EventArgs e)
        {
            ModificateData f12 = new ModificateData();
            f12.ShowDialog();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info f10 = new Info();
            f10.ShowDialog();
        }
    }
}
