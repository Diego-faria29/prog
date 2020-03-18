using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorComprimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Comprimentos comprimento = new Comprimentos();
            comprimento.Quilometro = 1;
            Console.WriteLine("km");
            Console.WriteLine( comprimento.Quilometro);
            Console.WriteLine("m ");
            Console.WriteLine( comprimento.Metro);
            Console.WriteLine("cm ");
            Console.WriteLine(comprimento.Centimetro);
            Console.WriteLine("nn ");
            Console.WriteLine(comprimento.Milimetro);
            Console.WriteLine("um ");
            Console.WriteLine(comprimento.Micrometro);
            Console.WriteLine("Nm");
            Console.WriteLine(comprimento.Nanometro);
            Console.WriteLine("milha");
            Console.WriteLine(comprimento.Milha);
            Console.WriteLine("yd");
            Console.WriteLine(comprimento.Jarda);
            Console.WriteLine("ft");
            Console.WriteLine(comprimento.Pe);
            Console.WriteLine("pol");
            Console.WriteLine(comprimento.Polegada);
            Console.WriteLine("NM");
            Console.WriteLine(comprimento.Milhanautica);



            System.Console.ReadKey();
        }
    }
}
