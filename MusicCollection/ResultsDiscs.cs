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
    public partial class ResultsDiscs : Form
    {
        public ResultsDiscs(List<Disk> disks)
        {
            InitializeComponent();
            dataGridView1.DataSource = disks;
            dataGridView1.Columns["Collective"].Visible = false;
            dataGridView1.Columns["Publisher"].Visible = false;
            dataGridView1.Columns["Genres"].Visible = false;
        }
        public ResultsDiscs(List<Collective> collectives)
        {
            InitializeComponent();
            dataGridView1.DataSource = collectives;
        }
        public ResultsDiscs(List<Genre> genres)
        {
            InitializeComponent();
            dataGridView1.DataSource = genres;
            dataGridView1.Columns["Disks"].Visible = false;
        }
    }
}
