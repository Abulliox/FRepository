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
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string conString = " data source=HELL;initial catalog=abediDB;integrated security=True;MultipleActiveResultSets=True; ";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "insert into student(course_id,student_number,major_id,payment_id) values ('" + scidtxt.Text + "' , '" + studentnumbertxt.Text + "' , '" + midtxt.Text + "' , '" + pidtxt.Text + "');", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        MessageBox.Show(" Data Insert ");
                        scidtxt.Clear();
                        studentnumbertxt.Clear();
                        midtxt.Clear();
                        pidtxt.Clear();
                    }
                }
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            string conString = " data source=HELL;initial catalog=abediDB;integrated security=True;MultipleActiveResultSets=True; ";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "select * from student ;", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                sresaulttxt.Text += reader.GetValue(i) + " , ";

                            }
                            sresaulttxt.Text += "\r\n";
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

