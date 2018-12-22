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
    public partial class Payment_Form : Form
    {
        public Payment_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = " data source=HELL;initial catalog=abediDB;integrated security=True;MultipleActiveResultSets=True; ";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "insert into payment(amount,payment_date) values ('" + amounttxt.Text + "' , '" + datetxt.Text +"');", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        MessageBox.Show(" Data Insert ");
                        amounttxt.Clear();
                        datetxt.Clear();
                      
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
                    "select * from payment ;", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                presaulttxt.Text += reader.GetValue(i) + " , ";

                            }
                            presaulttxt.Text += "\r\n";
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
    }
