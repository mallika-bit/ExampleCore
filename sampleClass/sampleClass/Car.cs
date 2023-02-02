using System;
using System.Collections.Generic;
using System.Text;

namespace sampleClass
{
   public class Car
    {
        public string name { get; set; }

        public int NoWheels { get; set; }

        public Car()
        {
            name = "mallika";
        }
    }
    class Plane
    {
        public void example()
        {
            Car ca = new Car();
            
            Console.WriteLine(ca.name);
        }
      

       
        
        public int speed { get; set; }
        
    }
}
