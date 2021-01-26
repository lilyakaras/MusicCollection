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
    public partial class ModificateData : Form
    {
        public ModificateData()
        {
            InitializeComponent();
        }

        private void buttonAllCollectives_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {

                bindingSource1.DataSource = context.Collectives.ToList();
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Collective s = new Collective();
            s = dataGridView1.CurrentRow.DataBoundItem as Collective;
            using (MyDbContext context = new MyDbContext())
            {
                var res = context.Collectives.Where(x => x.IdCollective == s.IdCollective).FirstOrDefault();
                res.Name = s.Name;
                context.SaveChanges();
            }
        }

        private void buttonAddCollective_Click(object sender, EventArgs e)
        {
            AddCollectiveGenre f13 = new AddCollectiveGenre();
            f13.Text = "Add Collective";
            if (f13.ShowDialog() == DialogResult.OK)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    bindingSource1.DataSource = context.Collectives.ToList();
                    dataGridView1.DataSource = bindingSource1;
                }
            }
        }

        private void buttonDeleteCollective_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCollective"].Value.ToString());
                    var s1 = context.Collectives.Where(x => x.IdCollective == id).FirstOrDefault();
                    context.Collectives.Remove(s1);
                    context.SaveChanges();
                    bindingSource1.DataSource = context.Collectives.ToList();
                    dataGridView1.DataSource = bindingSource1;
                }
            }
        }

        private void buttonAllPublishers_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                bindingSource1.DataSource = context.Publishers.ToList();
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Publisher s = new Publisher();
            s = dataGridView1.CurrentRow.DataBoundItem as Publisher;
            using (MyDbContext context = new MyDbContext())
            {
                var res = context.Publishers.Where(x => x.IdPublisher == s.IdPublisher).FirstOrDefault();
                res.Name = s.Name;
                res.Country = s.Country;
                context.SaveChanges();
            }
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            AddPublisher f14 = new AddPublisher();
            if (f14.ShowDialog() == DialogResult.OK)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    bindingSource1.DataSource = context.Publishers.ToList();
                    dataGridView1.DataSource = bindingSource1;
                }
            }
        }

        private void buttonDeletePublisher_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdPublisher"].Value.ToString());
                    var s1 = context.Publishers.Where(x => x.IdPublisher == id).FirstOrDefault();
                    context.Publishers.Remove(s1);
                    context.SaveChanges();
                    bindingSource1.DataSource = context.Publishers.ToList();
                    dataGridView1.DataSource = bindingSource1;
                }
            }
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            AddCollectiveGenre f13 = new AddCollectiveGenre("genre");
            f13.Text = "Add Genre";
            if (f13.ShowDialog() == DialogResult.OK)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    bindingSource1.DataSource = context.Genres.ToList();
                    dataGridView1.DataSource = bindingSource1;
                    dataGridView1.Columns["Disks"].Visible = false;
                }
            }
        }

        private void buttonAllGenres_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                bindingSource1.DataSource = context.Genres.ToList();
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged1;
                dataGridView1.Columns["Disks"].Visible = false;
            }
        }

        private void DataGridView1_CellValueChanged1(object sender, DataGridViewCellEventArgs e)
        {
            Genre s = new Genre();
            s = dataGridView1.CurrentRow.DataBoundItem as Genre;
            using (MyDbContext context = new MyDbContext())
            {
                var res = context.Genres.Where(x => x.IdGenre == s.IdGenre).FirstOrDefault();
                res.Title = s.Title;
                context.SaveChanges();
            }
        }

        private void buttonDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdGenre"].Value.ToString());
                    var s1 = context.Genres.Where(x => x.IdGenre == id).FirstOrDefault();
                    context.Genres.Remove(s1);
                    context.SaveChanges();
                    bindingSource1.DataSource = context.Genres.ToList();
                    dataGridView1.DataSource = bindingSource1;
                    dataGridView1.Columns["Disks"].Visible = false;
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser f11 = new AddUser();
            f11.Text = "Add User";
            if (f11.ShowDialog() == DialogResult.OK)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    bindingSource1.DataSource = context.Users.ToList();
                    dataGridView1.DataSource = bindingSource1;
                }
            }
        }

        private void buttonAllUsers_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                bindingSource1.DataSource = context.Users.ToList();
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged2;
            }
        }

        private void DataGridView1_CellValueChanged2(object sender, DataGridViewCellEventArgs e)
        {
            User s = new User();
            s = dataGridView1.CurrentRow.DataBoundItem as User;
            using (MyDbContext context = new MyDbContext())
            {
                var res = context.Users.Where(x => x.IdUser == s.IdUser).FirstOrDefault();
                res.FirstName = s.FirstName;
                res.LastName = s.LastName;
                res.Login = s.Login;
                res.Password = s.Password;
                res.IsClient = s.IsClient;
                context.SaveChanges();
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (MyDbContext context = new MyDbContext())
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdUser"].Value.ToString());
                    var s1 = context.Users.Where(x => x.IdUser == id).FirstOrDefault();
                    context.Users.Remove(s1);
                    context.SaveChanges();
                    bindingSource1.DataSource = context.Users.ToList();
                    dataGridView1.DataSource = bindingSource1;

                }
            }
        }
    }
}
