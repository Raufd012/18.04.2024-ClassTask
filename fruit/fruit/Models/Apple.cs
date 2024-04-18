using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit.Models
{
    class Apple : Fruit
    {
        public int VitaminA;
        public int VitaminB;

        public Apple(decimal price, string sort, int vitA, int vitB):base(price, sort)
        {
            VitaminA = vitA;
            VitaminB = vitB;
        }
        public override void taste()
        {
            Console.WriteLine("Dadlidir");
        }
    }
}
