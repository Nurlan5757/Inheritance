using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Laptop:Device
    {
        public int PortCount;


        public Laptop(int portCount, double width, double height, double weight): base(width, height, weight)
        {
            PortCount=portCount;
        }
    }
}
