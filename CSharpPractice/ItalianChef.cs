using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class ItalianChef : Chef
    {
        public override void MakesSpecialDish()
        {
            Console.WriteLine("The chef makes pasta");
        }
    }
}
