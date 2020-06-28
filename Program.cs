using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_v6
{
    class Program
    {
        static void Main(string[] args)
        {
            Plants.Description();

            Plants romashka = new Plants("flower", 12.3, 4);

            //romashka.sett("flower", 12.3, 4);

            romashka.get_inf();

            Plants tomat = new Plants();

            tomat.sett("vegetable", 8, 2, "red");
            tomat.get_inf();

            Trees bereza = new Trees(30, 50, true);
            bereza.get_inf();

            Plants.pluss();

            Console.ReadKey();
        }
    }
}
