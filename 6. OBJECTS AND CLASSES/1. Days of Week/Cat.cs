using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJECTS_AND_CLASSES
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set;}
        public string Color { get; set; }
        public bool IsAsleep { get; set; }
        public string SayHello()
        {
            return $"Hi, I am {Name}! I am {Age} years old";
        }
        public void GoToSLeep()
        {
            IsAsleep = false;
        }
    }
    

}
