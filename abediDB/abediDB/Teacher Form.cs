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
    public partial class Teacher_Form : Form
    {
        public Teacher_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = " data source=HELL;initial catalog=abediDB;integrated security=True;MultipleActiveResultSets=True; ";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "select * from teacher ;", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                tresaulttxt.Text += reader.GetValue(i) + " , ";

                            }
                            tresaulttxt.Text += "\r\n";
                        }
                    }
                }
            }
        }

        private void Teacher_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = " data source=HELL;initial catalog=abediDB;integrated security=True;MultipleActiveResultSets=True; ";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "insert into teacher(person_id,course_id,grad) values ('" + pidtxt.Text + "' , '" + cidtxt.Text + "' , '" + grade.Text +"');", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        MessageBox.Show(" Data Insert ");
                        pidtxt.Clear();
                        cidtxt.Clear();
                        grade.Clear();
                     
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
