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
    public partial class AddPublisher : Form
    {
        public AddPublisher()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                Publisher collec = new Publisher() { Name = textBoxName.Text, Country = textBoxCountry.Text };
                context.Publishers.Add(collec);
                context.SaveChanges();
            }
        }
    }
}
