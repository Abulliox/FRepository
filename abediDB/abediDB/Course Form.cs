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
    public partial class Course_Form : Form
    {
        public Course_Form()
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
                    "insert into course(level) values ('" + leveltxt.Text + "');", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        MessageBox.Show(" Data Insert ");
                        leveltxt.Clear();

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
                    "select * from course ;", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                cresaulttxt.Text += reader.GetValue(i) + " , ";

                            }
                            cresaulttxt.Text += "\r\n";
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

