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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[a-zA-Z0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[a-zA-Z0-9!*+-]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                User u1 = context.Users.Where(x => x.Login == textBoxLogin.Text).FirstOrDefault();
                if (u1 != null && u1.Password == textBoxPassw.Text && u1.IsClient == false)
                {
                    ActionsForDisk form2 = new ActionsForDisk();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                { MessageBox.Show("Login or password not correct"); }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.InitialDelay = 100;
            t1.SetToolTip(textBoxLogin, "Login may contain next symbols-\"a-z 0-9 \"");
        }

        private void textBoxPassw_Enter(object sender, EventArgs e)
        {
            ToolTip t2 = new ToolTip();
            t2.InitialDelay = 100;
            t2.SetToolTip(textBoxPassw, "Password may contain next symbols-\"a-z 0-9 !*+-\"");
        }
    }
}
