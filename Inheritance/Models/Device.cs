using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Device
    {
        public double Width;
        public double Height;
        public double Weight;
        int count = 0;

        public Device(double width, double height, double weight)
        {
            Width = width;
            Height = height;
            Weight = weight;
        }


        public void OpenDevice()
        {
            
            if (count == 0)
            {
            Console.WriteLine("Device opening… ");
            Console.Clear();
                count++;
           
            }
            else 
            {
             Console.WriteLine("Device already opened");
            }
            
            
        }

        public void CloseDevice()
        {
            if (count == 0)
            {
                Console.WriteLine("Device opening… ");
                Console.Clear();
                count++;

            }
            else
            {
                Console.WriteLine("Device already opened");
            }

        }

    }
}
