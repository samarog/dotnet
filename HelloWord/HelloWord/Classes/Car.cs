using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public class Car
    {
        public string color = "red"; // field
        public string model = "BMW"; // field

        public void Show()
        {
            Console.WriteLine($"The {model} is {color}");
        }

    }
}
