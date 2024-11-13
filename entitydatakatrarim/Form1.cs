using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entitydatakatrarim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TumSiparisler_Click(object sender, EventArgs e)
        {
            SQLFULLEntities db = new SQLFULLEntities();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Musteri.ToList();
        }

        private void Ilk5Siparsi_Click(object sender, EventArgs e)
        {
            SQLFULLEntities db = new SQLFULLEntities();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Musteri.Take(5).ToList();
        }
    }
}
