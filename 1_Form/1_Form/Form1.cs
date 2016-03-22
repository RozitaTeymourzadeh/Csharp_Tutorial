using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Create GUI window */

namespace _1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = "Rozita Teymourzadeh";
            MessageBox.Show(name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int age = 35;
            MessageBox.Show(age.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object course = "Electronic";
            MessageBox.Show(course.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool Engineer = true;
            MessageBox.Show(Engineer.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Rozita Teymourzadeh";
            button5.Enabled = false;
            button5.Height = 100;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.MaxLength = 5;// To limmit the no. of character showing in text box
            textBox1.Text = "C# For beginners!!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "CCG")
            {
                MessageBox.Show("You have been working in CCG for 4 Years!");
            }
            else if (textBox2.Text == "UKM")
            {
                MessageBox.Show("You have been working in UKM for 4.5 Years!");
            }
            else if (textBox2.Text == "UCSI")
            {
                MessageBox.Show("You have been working in UCSI for 5 Years!");
            }
            else if (textBox2.Text == "Neonode")
            {
                MessageBox.Show("You have been working in Neonode for 2 Years!");
            }
            else
            {
                MessageBox.Show("You have not work for this company!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
          if (checkBox1.Checked)
          {
              button8.Enabled = false;
          }
          else if (!checkBox1.Checked)
          {
              button8.Enabled = true;
          }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
