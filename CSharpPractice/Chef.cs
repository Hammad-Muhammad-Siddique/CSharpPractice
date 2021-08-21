using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Chef
    {
        public static void MakesChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }

        public static void MakesSalad()
        {
            Console.WriteLine("The chef makes salad");
        }

        public virtual void MakesSpecialDish()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }
}
