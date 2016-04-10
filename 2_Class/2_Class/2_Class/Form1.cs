/*
 ********************************************
 
 Author: Rozita Teymourzadeh
 website: http://www.rozita-teymourzadeh.com/
 Date: Apr.2016
 Purpose: C# Tutorial for beginner
 
 ********************************************
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            catch (Exception ex)
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
            for (int i = 0; i <= 2; i++)
            {
                MessageBox.Show(sister[i]);
                sister[i] = "Eliza";
                MessageBox.Show(sister[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)// Struct
        {
            JoblessList JoblessList1 = new JoblessList();
            JoblessList1.Name = "Anita";
            JoblessList1.Age = 36;
            JoblessList1.ClearJoblessListInfo();

            JoblessList JoblessList2 = new JoblessList("Rozita");
            JoblessList2.Name = "Rozita";
            JoblessList2.Age = 35;
            JoblessList2.ClearJoblessListInfo();
        }

        private void button7_Click(object sender, EventArgs e)// Partial Class
        {
            MyClass2 neonode = new MyClass2();
            neonode.ShowMessage("Partial class has been implemented successfully");
        }

        private void button8_Click(object sender, EventArgs e) // Abstract
        {
            SecondDrive drive = new SecondDrive();
            drive.ShowMessage("Abstract has been Implemented!");
        }

        private void button9_Click(object sender, EventArgs e) // Deligate
        {
            MyDelegate mc = new MyDelegate();
            mc.ShowPrint();
        }

        private void button10_Click(object sender, EventArgs e)// Event
        {
            MyEvent mc = new MyEvent();
            mc.onPropertyChanged += mc_onPropertyChanged;// Press 2 tab after typing += to auto generate the method
            mc.Name = "Rozita";
        }

        void mc_onPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show(" Event: Property has changed");
        }

        private void button11_Click(object sender, EventArgs e)// Ternary Operator
        {
            //string CheckBox = "";
            //if (checkBox1.Checked) { CheckBox = "CheckBox is ticked";}
            //else { CheckBox = "CheckBox is NOT ticked"; }
            string CheckBox = (checkBox1.Checked) ? "CheckBox is ticked!" : "CheckBox is NOT ticked!";
            MessageBox.Show(CheckBox);
        }

        private void button12_Click(object sender, EventArgs e)// Open File Dialog
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";// Edit the title of opened window
            ofd.Filter = "PNG Image|*.png|BIK|*.bik";//By this line you can filter what type of file can be opened here
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
            }
        }

        private void button13_Click(object sender, EventArgs e)// Variable
        {
            sbyte mybyte = -2; //for sign "s", for unsign "u"
            ushort myshort = 0;
            UInt16 myshort1 = myshort;
            uint myint = 0;
            UInt32 myint1 = myint;
            ulong mylong = 0;
            UInt64 mylong1 = mylong;

            float myfloat = 0.5F;
            double mydouble = 0.5;
            char mychar = 'c';

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)// Stream read 1,2
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                //No. #1
                //textBox2.Text = sr.ReadToEnd(); // To print the text 
                //No. #2
                //textBox2.Text = sr.BaseStream.ReadByte().ToString("X"); // To print Text in hex value
                //No. #3

                byte[] buffer = new byte[3];
                sr.BaseStream.Position = 0x0C;//will start from byte C in hex byte to read 
                sr.BaseStream.Read(buffer, 0, 3);
                foreach (byte mybyte in buffer)
                    textBox2.Text += mybyte.ToString("X") + " ";

                sr.Dispose();// To close the file
            }
        }

        private void button15_Click(object sender, EventArgs e) // Stream read 3
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                char c = (char)sr.Peek();//Read Position @ #0
                char c1 = (char)sr.Read(); // Read Position @ #1
                char c2 = (char)sr.Read();//
                MessageBox.Show(c.ToString() + ":" + c1.ToString() + ":" + c2.ToString());
            }
        }
        string path1;
        private void button16_Click(object sender, EventArgs e)// Stream Writer
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button16.Enabled = true;
                path1 = ofd.FileName;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            /* To write character */
            //StreamWriter sw = new StreamWriter(File.OpenWrite(path));// The new text will be written continuously
            StreamWriter sw = new StreamWriter(File.Create(path1));// The new text will be written in new file and old text will be deleted
            //sw.Write(textBox3.Text);//To be written in the same line
            sw.WriteLine(textBox3.Text);
            sw.WriteLine("This is second line");

            /* To write HEX */
            sw.BaseStream.Position = 0x20;
            sw.BaseStream.WriteByte(0xFF);

            /* To write a array of HEX */
            sw.BaseStream.Position = 0x20;
            byte[] buffer = { 0xff, 0xff, 0xff };
            sw.BaseStream.Write(buffer, 0, 3);
            sw.Dispose();

        }

        string path2;
        private void button19_Click(object sender, EventArgs e)// Binary Read
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button18.Enabled = true;
                path2 = ofd.FileName;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.OpenRead(path2));
            br.BaseStream.Position = 0x00;
            //textBox4.Text = br.ReadChar().ToString();//Read 1 character
            // to read the byte from LSB side
            textBox4.Text = br.ReadInt16().ToString("X");// Read 2 byte from LSB to MSB means 00 01 is 01 00
            foreach (char myChar in br.ReadChars(4))
                textBox4.Text += myChar;

            /* TO Reverse the byte
            byte[] buffer = br.ReadBytes(2);
            Array.Reverse(buffer);
            textBox4.Text = BitConverter.ToInt16(buffer, 0).ToString("X");
             */
            br.Dispose();
        }
        string path3;
        private void button21_Click(object sender, EventArgs e)// Binary Write
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button20.Enabled = true;
                path3 = ofd.FileName;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(path3));
            short myShort = 0x1234;// To reverse  the byte in order of MSB to LSB
            byte[] buffer = BitConverter.GetBytes(myShort);
            Array.Reverse(buffer);
            bw.Write(buffer);
            //bw.Write("C");
            bw.Dispose();
        }

        private void button22_Click(object sender, EventArgs e)//Save File
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";// To filter .txt file
            sfd.Title = "Write in File";// To give title to window
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
            string path4 = sfd.FileName;
            BinaryWriter bw = new BinaryWriter(File.Create(path4));
            bw.Write("Example Text File.");
            bw.Dispose();
            }
        }

        private void button23_Click(object sender, EventArgs e)//Convert Data
        {
            int myInt = Convert.ToInt32(textBox5.Text) + 2;
            //char c = Convert.ToChar(textBox5.Text);//for converting to Char
            MessageBox.Show(myInt.ToString());

        }

        private void button24_Click(object sender, EventArgs e)// Casting and Substring and Trim and Replace and Remove
        {
            object myObject = "Casting is performed";
            if (myObject is string) MessageBox.Show((string)myObject);

            Control myControl = button24;
            if (myControl is Button) 
            {
                //Button myBotton = (Button)myControl;// casting way 1
                Button myBotton = myControl as Button;// casting way 2
                MessageBox.Show(myBotton.Text);
            }
            
            /* SubString and Trim*/
            string Name = "Rozita Teymourzadeh";
            /*#1 Way*/
            // string LastName = Name.Substring(7,12);// 7 is starting index and 12 is length that want to be printed
            /*#1 Way*/
            string FirstName = Name.Substring(0, Name.IndexOf(' '));
            string LastName = Name.Substring(Name.IndexOf(' ') + 1);//+1 is due to excluding space index
            MessageBox.Show("Substring First Name is: " + FirstName + " and Substring Last Name is: " + LastName);

            string JobTitle = "         Senior Electronic Design Engineer         ";
            string RawJobTitle = JobTitle.Trim();// Trim to remove the spaces for the string variable
            MessageBox.Show("No Trim: " + JobTitle);
            MessageBox.Show("Trim: " + RawJobTitle);
            MessageBox.Show("TrimStart: " + JobTitle.TrimStart());
            MessageBox.Show("TrimEnd: " + JobTitle.TrimEnd());

            /* Remove and Reomove*/

            string message = "This is test for Remove and replace syntax";
            MessageBox.Show(message);
            MessageBox.Show(message.Remove(23,19));
            MessageBox.Show(message.Replace("Remove and "," "));


        }

        private void button25_Click(object sender, EventArgs e)// Split in Array
        {
            string nameList = "Anita; Rozita; Panteha";//Split in Array
            String[] ArrayNameList = nameList.Split(';');
            foreach (string name in ArrayNameList)
            {
                MessageBox.Show("Member of ArrayNameList is: " + name);
            }

            string _Letters = "abcdefghi"; //.ToCharArray
            char[] Lettres = _Letters.ToCharArray();
            foreach (char c in Lettres)
            {
                MessageBox.Show(c.ToString());
            }
                
        }

        private void button26_Click(object sender, EventArgs e)// Math Class
        {
            label1.Text = Math.Abs(-56).ToString();
            label1.Text = Math.PI.ToString();
            label1.Text= Math.Round(7.432, 2).ToString();

        }

        private void button27_Click(object sender, EventArgs e)// Random No
        {
           /* Generate Random No. */
            Random r = new Random();
            MessageBox.Show("Generate No btw 0 to 100 :" + r.Next(0, 100).ToString());//No. btw 0 to 100
            
            /* Generate Random No. and save in byte Array */

            byte[] buffer = new byte[5];
            Random r1 = new Random();
            r1.NextBytes(buffer);
            MessageBox.Show("Generate byte Random No.: " + BitConverter.ToString(buffer));

            /* Generate Random No. in double means 0 and 1 */

            Random r2 = new Random();
            MessageBox.Show("Generate Double Random No.: " + r2.NextDouble().ToString());

            /* Generate Random Character */
            char[] letters = "fdyrewqTGRFUYYILKBTDASAcdrhghb12345678900009876543".ToCharArray();
            Random r3 = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r3.Next(0, 50)].ToString();
            }
            MessageBox.Show("Generate Random Character: " + randomString);

        }

        private void button28_Click(object sender, EventArgs e)//Folder Browser Dialog
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            fbd.Description = "Rozita set a test description for browser";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(fbd.SelectedPath);
            }

        }
    }
}
