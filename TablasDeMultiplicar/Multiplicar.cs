using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDeMultiplicar
{
    public class Multiplicar
    {
        public static void MultiCollection()
        {
            
            int num, i;
            Console.WriteLine(" Digite la tabla de multiplicar del numero que desea visualizar por favor ");
            num = int.Parse(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                Console.WriteLine("{0} x {1} = {2} ", num, i, (num * i));
            }
        }
    }
}
