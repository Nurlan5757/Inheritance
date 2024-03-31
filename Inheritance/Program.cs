using Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Mobile mob = new Mobile(1234354, 12, 3.2, 4);
            

            mob.OpenDevice();
            mob.OpenDevice();


            mob.CloseDevice();
            mob.CloseDevice();

            /*Device dev = new Device(12, 3.2, 4);*/







        }
    }
}
