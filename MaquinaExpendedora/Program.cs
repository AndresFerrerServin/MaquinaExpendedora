using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Total = Maquina.Eleccion();

            Maquina.Cambio(Total);

            Console.ReadKey();
            
        }
    }
}
