using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class Dice
    {


        static int throwDice()
        {

            int D1;
            int D2;
            int total;

            Random rnd1 = new Random();

            rnd1.next(1, 7);
            D1 = rnd1;
            D2 = rnd1.Next(1, 7);


            total = D1 + D2;
            return total;
        }
    }
}
