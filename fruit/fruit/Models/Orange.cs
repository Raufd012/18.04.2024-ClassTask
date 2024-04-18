using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit.Models
{
    class Orange : Fruit
    {
        public int VitaminC;

        public Orange(decimal price, string sort, int vitC) : base(price, sort)
        {
            VitaminC = vitC;

        }
        public override void taste()
        {
            Console.WriteLine("Vitaminlidir");
        }
    }
}
