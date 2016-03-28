using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {
        string Name;
        
        public MyClass(string name)
        {
            Name = name;
        }
        public string name()
        {
            return Name;
        }
        public static void MessageBox(string message)
        {
           System.Windows.Forms.MessageBox.Show(message);
        }


    }
}
