using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit.Models
{
    class PineApple : Fruit
    {
        public int VitaminD;
        public int VitaminE;
        public PineApple(decimal price, string sort, int vitD, int vitE) : base(price, sort)
        {
            VitaminD = vitD;
            VitaminE = vitE;

        }
        public override void taste()
        {
            Console.WriteLine("Tursmezedir");
        }
    }
}
