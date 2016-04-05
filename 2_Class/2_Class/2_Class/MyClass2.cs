using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class
{
    partial class MyClass2
    {
        public string Name = "Rozita";
        public int Age = 35;
        partial void Message(string message); // in partial class we can not define the method here! should be defined in another partial class. 
    }
}
