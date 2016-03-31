using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_Class;

namespace _2_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// Class
        {
            MyClass.print("Rozita Teymourzadeh");
            MyClass.print(35);
        }

        private void button2_Click(object sender, EventArgs e)//Name
        {
            MyClass mc = new MyClass("Rozita");
            mc.Name = "";
            MessageBox.Show(mc.Name);
        }

        private void button3_Click(object sender, EventArgs e)//Exception
        {
           try
            { 
               MyClass.checkString(""); 
            }
           catch(Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)//Inheritance
        {
            Employee Bob = new Employee();
            Bob.printSprcial();// From Employer Class
            Bob.print("Build new print method"); // From Student Class
            Bob.ImyPrint();// From IMyintrface interface
        }

        private void button5_Click(object sender, EventArgs e) // Index
        {
            Index sister = new Index();
            for(int i = 0; i<= 2; i++)
            {
                MessageBox.Show(sister[i]);
                sister[i] = "Eliza";
                MessageBox.Show(sister[i]);
            }
        }
    }
}
