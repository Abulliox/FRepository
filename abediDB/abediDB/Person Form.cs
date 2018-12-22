using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace abediDB
{
    public partial class Person_Form : Form
    {
        public Person_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = " data source=HELL;initial catalog=abediDB;integrated security=True;MultipleActiveResultSets=True; ";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "insert into person(first_name,last_name,national_id,age) values ('" + nametxt.Text + "' , '" + familytxt.Text + "' , '" + nidtxt.Text + "' , '" + agetxt.Text + "');", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        MessageBox.Show(" Data Insert ");
                        nametxt.Clear();
                        familytxt.Clear();
                        agetxt.Clear();
                        nidtxt.Clear();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = " data source=HELL;initial catalog=abediDB;integrated security=True;MultipleActiveResultSets=True; ";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "select * from person ;", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                resaulttxt.Text += reader.GetValue(i) + " , ";

                            }
                            resaulttxt.Text += "\r\n";
                        }
                    }
                }
            }
        }
    }
}
