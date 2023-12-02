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
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
        }

        private void customers_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\code barname sazi visual studio\databasee\databasee\Database1.mdf"";Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                string cmd = "SELECT * FROM customers_Table";
                SqlCommand command = new SqlCommand(cmd,connection);

                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read()) ;

                {
                    listBox1.Items.Add(sdr["name"] + "," +sdr["lastname"]);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\code barname sazi visual studio\databasee\databasee\Database1.mdf"";Integrated Security=True";
                SqlConnection sc = new SqlConnection(cs);
                sc.Open();
                string cmd = "DELETE FROM customers_Table WHERE lastname='Ghaedi'";
                SqlCommand command = new SqlCommand(cmd, sc);
                if (command.ExecuteNonQuery() == 2)
                    MessageBox.Show("با موفقیت حذف شد");
                else
                    MessageBox.Show("ایرادی وجود دارد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\code barname sazi visual studio\databasee\databasee\Database1.mdf"";Integrated Security=True";
                SqlConnection sc = new SqlConnection(cs);
                sc.Open();

                string cmd = "UPDATE  customers_Table SET hosseini=hosseinizade WHERE name='Ali'";
                SqlCommand command = new SqlCommand(cmd, sc);
                MessageBox.Show(command.ExecuteNonQuery().ToString());
                    

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
