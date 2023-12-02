using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databasee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phones ph = new phones();
            ph.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addphone ap = new addphone();
            ap.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customers cs = new customers();
            cs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addcustomer ac = new addcustomer();
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phones ph = new phones();
            ph.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            phones ph = new phones();
            ph.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customers cs = new customers();
            cs.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customers cs = new customers();
            cs.Show();
        }
    }
}
