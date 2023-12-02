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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace databasee
{
    public partial class addphone : Form
    {
        public addphone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {





                string model = textBox1.Text;
                string colour = textBox2.Text;
                string storage = textBox3.Text;
                string ram = textBox4.Text;
                string lenz = textBox5.Text;
                string battery = textBox6.Text;
                string simcard = textBox7.Text;
                string sensor = textBox8.Text;

                string cs = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""D:\code barname sazi visual studio\databasee\databasee\Database1.mdf""; Integrated Security = True";

                SqlConnection sc = new SqlConnection(cs);
                sc.Open();


                string cmd = "INSERT INTO phones_table (model,colour,storage,ram,lenz,battery,simcard,sensor) VALUES" +
                 "('" + model + "','" + colour + "','" + storage + "','" + ram + "','" + lenz + "','" + battery + "','" + simcard + "','" + sensor + "')";
                SqlCommand command = new SqlCommand(cmd, sc);
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("با موفقیت افزوده شد");
                else
                    MessageBox.Show("ایرادی وجود دارد");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

        }  
    }
}
