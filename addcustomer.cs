using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databasee
{
    public partial class addcustomer : Form
    {
        public addcustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {



                string name = textBox1.Text;
                string lastname = textBox2.Text;

                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\code barname sazi visual studio\databasee\databasee\Database1.mdf"";Integrated Security=True";

                SqlConnection sc = new SqlConnection(cs);
                sc.Open();

                string cmd = "INSERT INTO customers_Table(name,lastname) VALUES ('" + name + "','" + lastname + "')";
                SqlCommand command = new SqlCommand(cmd, sc);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
