using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance.Models
{
    internal class Mobile:Device
    {
        public int Number;
        public string[] SimCards = new string[0];

        /* public Mobile(string[] simCards, double width, double height, double weight) :base(width, height, weight)
         {
            SimCards =  simCards;
         }*/

        public Mobile(double width, int number, double height, double weight) : base(number, width, height, weight)
        {
            Number = number;

        }


        /* public void Number()
         {

         }*/



        public void SimCardCount(int mincount, int maxcount)
        {
            mincount = 1;
            maxcount = 2;


           /* if (SimCards.Length >= 1)
            {
                Console.WriteLine();
            }
            else if (SimCards.Length <=2)
            {

            }*/
        }


       




        public void AddNumber(string simCard)
        {
            Array.Resize(ref SimCards, SimCards.Length + 1);
            SimCards[SimCards.Length - 1] = simCard;
        }






        public void RemoveNumber(int number)
        {
            string[] newArr = new string[SimCards.Length - 1];
            int j = 0;
            for (int i = 0; i < SimCards.Length; i++)
            {
                if (SimCards[i].Number != number)
                {
                    newArr[j] = SimCards[i];
                    j++;
                }
            }
            SimCards = newArr;
        }




        public void GetNumbers() : this( mincount, maxcount )
        {

        }
    }
}
