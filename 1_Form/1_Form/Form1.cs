using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNamespace;

/* Create GUI window */

namespace _1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// Button
        {

            string name = "Rozita Teymourzadeh";
            MessageBox.Show(name);
        }

        private void button2_Click(object sender, EventArgs e)// Button
        {
            int age = 35;
            MessageBox.Show(age.ToString());
        }

        private void button4_Click(object sender, EventArgs e)// Button
        {
            object course = "Electronic";
            MessageBox.Show(course.ToString());
        }

        private void button3_Click(object sender, EventArgs e)// Button
        {
            bool Engineer = true;
            MessageBox.Show(Engineer.ToString());
        }

        private void button5_Click(object sender, EventArgs e)// Button
        {
            button5.Text = "Rozita Teymourzadeh";
            button5.Enabled = false;
            button5.Height = 100;

        }

        private void button6_Click(object sender, EventArgs e)// Text Box
        {
            textBox1.MaxLength = 5;// To limmit the no. of character showing in text box
            textBox1.Text = "C# For beginners!!";
        }

        private void button7_Click(object sender, EventArgs e)// Text Box and if else if
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

        private void button8_Click(object sender, EventArgs e)// Check Box
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

        private void button9_Click(object sender, EventArgs e)
        {
            string[] name = new string[5]; // Need to specify the size
            name[1] = "Rozita";
            MessageBox.Show(name[1]);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<string> Names = new List<string>(); // No need to specify the size
            List<int> Numbers = new List<int>();
            Names.Add("Rozita in List");
            Numbers.Add(35);

            MessageBox.Show(Names[0], Numbers[0].ToString());
            MessageBox.Show(Numbers[0].ToString());


        }

        private void button11_Click(object sender, EventArgs e)// foreach
        {
            for (int i = 0; i < 6; i++) 
            {
                if (i == 4) break;
                MessageBox.Show("C# Tutorial Series " + i.ToString(), "Series No");
                if (i == 3) continue;
            }
            List<string> Names = new List<string>();
            Names.Add("Anita");
            Names.Add("Rozita");
            Names.Add("Panteha");

            foreach (string s in Names)
            {
                MessageBox.Show(s);
            }


        }

        private void button12_Click(object sender, EventArgs e)// do ... while
        {
            int i=0;
            do {

                textBox3.Text += i.ToString();
                i++;

            }while (i<10);
        }

        private void button13_Click(object sender, EventArgs e)// Try, Catch
        {
            try
            {
                string[] Names = new string[2];
                MessageBox.Show(Names[2]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                MessageBox.Show("The code is executed!!!");
            }
        }

        private void button14_Click(object sender, EventArgs e)// Function
        {
            Message("The Message function executed !!!","Test result");
        }
        void Message(string Message, string Title) 
        {
            MessageBox.Show(Message, Title);
        }

        private void button15_Click(object sender, EventArgs e)// Class
        {
            MyClass.MessageBox("First Class constructor Method!");
            MyClass mc = new MyClass("Rozita");
            mc.name();// if name() method is public can be read here if private so is produces error in the code
        }
    }
}
