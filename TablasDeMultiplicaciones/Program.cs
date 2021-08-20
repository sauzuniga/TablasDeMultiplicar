using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDeMultiplicar;
namespace TablasDeMultiplicaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "si";
            while (respuesta == "si")
            {
                Multiplicar.MultiCollection();
                Console.WriteLine(" Desea generar otra tabla de multiplicar diferente si/no ");
                respuesta = Console.ReadLine();
                
            }
            Console.ReadKey();
        }
    }
}
