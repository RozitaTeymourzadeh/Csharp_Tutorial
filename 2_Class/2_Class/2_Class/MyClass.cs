using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class
{
    class MyClass
    {
        /**********************Define enum*****************************************/
        enum NameList:byte// save data in byte size
        { 
        
            Rozita = 0, // Rozita is saved in NameList[0]
            Anita = 3,
            Panteha, 
        }

        NameList sister = NameList.Panteha;// load the variable

        /*********************Define Method******************************************/
        public static void print(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        public static void print(int message)// This is Method , needs to have ()
        {
            System.Windows.Forms.MessageBox.Show(message.ToString());
        }
        /************************Define Property Name***************************************/
        string nameString;
        public MyClass(string name)
        {
            nameString  = name;
            //Name = name;
        }
        public string Name // This is Property, No need to have ()
        {
            get {return nameString;}
            set { if (value == "") System.Windows.Forms.MessageBox.Show("You have not set any Name!"); }
        }
        /************************Define Exception***************************************/

        static Exception EmptyText = new Exception ("Error: Text is Empty!!");

        public static void checkString(string text)
        {
            if (text == "") throw EmptyText;
        }
        
      }
    /************************Define Inheritance / override/Interface***************************************/
    class Student /* base class*/
    {
        
        public string Name = "Rozita";
        public int Age = 35;
        public void print(string message)
        //public virtual void print (string message)// if we have virtual model need to have override replacing with new 
        {
            System.Windows.Forms.MessageBox.Show(message,"Title");
        }

    }
    class Employee : Student, IMyInterface// student inherit to Employee means all protected and public variables and methods will be allocated to Employee class too 
    /* drive class*/
    {
        public string hairColor = "Brown";
        public void printSprcial()
        {
            System.Windows.Forms.MessageBox.Show(base.Name, "Name");
            base.print(base.Age.ToString());
        }
        public new void print(string message)
        //public override void print(string message) 
        {
            System.Windows.Forms.MessageBox.Show(base.Name, "New title");
            System.Windows.Forms.MessageBox.Show(message, "New title 2");
        }
        public void ImyPrint()
        {
            base.print("This defination is for ImyPrint");
        }
    }
    interface IMyInterface  //in interface all items are public, we can not use access identifier. In interface we can not define the function, we can define function and method in class and inherit interface into that class 
    {
        void ImyPrint();
    }
    /************************Define Partial Class***************************************/

    partial class MyClass2 
    {
        public string address = "San Jose";
        public float salary = 2500;
        partial void Message(string message)// can not define access modifier hence should define another public method
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        public void ShowMessage(string message)
        {
            Message(message);
        }
    }

    /************************Define Index***************************************/
    class Index
	{
        string[] Name = { "Anita", "Rozita", "Pantea" };
        public string this[int index]// to access to array and modify it
            {
                get {return Name[index];}
                set{Name[index] = value;} 
            }
	}
    /************************Define Struct***************************************/
    struct JoblessList: IJoblessList// struct can be in herit to interface only not another Class
    {

        public JoblessList(string name)// constructor should get atleast one parameter and set all variables
        {
            Name = "";
            Age = 0;
        }
        public string Name;
        public int Age;
        public void ClearJoblessListInfo() 
        {
            Name = "";
            Age = 0;
        }
    }
    interface IJoblessList
    {
        //got inherit to Student Struct
    }
    
    /************************Define Abstract***************************************/

    abstract class HiddenDrive // Abstract hide the object from others file 
    {
        public static string Name = "Rozita";
        public static int Age = 35;
        public static void Message (string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        public abstract void ShowMessage(string message);
    }

    class SecondDrive: HiddenDrive 
    {
        public override void ShowMessage(string message)// to define abstract method, needs to override the method
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        
    }
    
    /************************Define Delegate***************************************/

    class MyDelegate 
    {
        delegate void DelegateBank(string message);// Delegate is using when simmilar method want to be executed within one delegate
        public void ShowPrint()
        {
            DelegateBank md = new DelegateBank(Print1);
            md += Print2;
            md("Delegate is implemented successfully!");
        }
        void Print1(string message) 
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        void Print2(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Test");
        }
    }

    /************************Define Event***************************************/
    class MyEvent
    {

        public event EventHandler onPropertyChanged;
        string name = ""; 
        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                onPropertyChanged(this, new EventArgs());
            }
            
        }
    }

}

