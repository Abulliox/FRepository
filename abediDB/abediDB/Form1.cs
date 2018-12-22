using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abediDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person_Form personform = new Person_Form();
            personform.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_Form teacherform = new Teacher_Form();
            teacherform.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_Form studentform = new Student_Form();
            studentform.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Course_Form courseform = new Course_Form();
            courseform.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Major_Form majorform = new Major_Form();
            majorform.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Payment_Form paymentform = new Payment_Form();
            paymentform.ShowDialog();
            this.Close();
        }
    }
}
