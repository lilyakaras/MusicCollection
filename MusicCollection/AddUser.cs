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
    public partial class AddUser : Form
    {
        User user1;
        public AddUser()
        {
            InitializeComponent();
        }
        public AddUser(User u)
        {
            InitializeComponent();
            user1 = new User();
            user1 = u;
            textBoxFirstName.Text = u.FirstName;
            textBoxLastName.Text = u.LastName;
            textBoxLogin.Text = u.Login;
            textBoxPassword.Text = u.Password;
            if (u.IsClient == true)
                checkBoxIsClient.Checked = true;
            else
                checkBoxIsClient.Checked = false;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.Text == "Add User")
            {
                try
                {
                    User user = new User(); ;
                    using (MyDbContext context = new MyDbContext())
                    {
                        if (checkBoxIsClient.Checked)
                            user.IsClient = true;
                        else
                            user.IsClient = false;

                        User newuser = new User()
                        {
                            FirstName = textBoxFirstName.Text,
                            LastName = textBoxLastName.Text,
                            Login = textBoxLogin.Text,
                            Password = textBoxPassword.Text,
                            IsClient = user.IsClient
                        };
                        context.Users.Add(newuser);
                        context.SaveChanges();
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
                        var c1 = context.Users.Where(x => x.IdUser == user1.IdUser).FirstOrDefault();
                        c1.FirstName = textBoxFirstName.Text;
                        c1.LastName = textBoxLastName.Text;
                        c1.Login = textBoxLogin.Text;
                        c1.Password = textBoxPassword.Text;
                        if (checkBoxIsClient.Checked)
                            c1.IsClient = true;
                        else
                            c1.IsClient = false;
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("Data not correct"); }
            }
            }
    }
}
