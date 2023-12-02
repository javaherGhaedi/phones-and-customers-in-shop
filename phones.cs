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
    public partial class phones : Form
    {
        public phones()
        {
            InitializeComponent();
        }

        private void phones_Load(object sender, EventArgs e)
        {
            try
            {

                string connectionstring = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\code barname sazi visual studio\\databasee\\databasee\\Database1.mdf\"; Integrated Security = True\r\n ";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                string cmd = "SELECT * FROM  phones_table ";
                SqlCommand command = new SqlCommand(cmd,connection);

                SqlDataReader sdr = command.ExecuteReader();
                while(sdr.Read())

                {
                    listBox1.Items.Add(sdr["model"] + "_" + sdr["colour"] + "_" + sdr["storage"]);
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

                string cmd = "DELETE FROM phones_table WHERE colour='gray' ";
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

                string cmd = "UPDATE phones_table SET '128'='256' WHERE model='samsung a72' ";
                SqlCommand command = new SqlCommand(cmd, sc);
                MessageBox.Show(command.ExecuteNonQuery().ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
