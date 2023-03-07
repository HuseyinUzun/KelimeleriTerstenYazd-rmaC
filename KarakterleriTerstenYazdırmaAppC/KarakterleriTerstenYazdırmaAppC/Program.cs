using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterleriTerstenYazdırmaAppC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle, terscumle = "";
            Console.Write("Kelime giriniz : ");
            cumle = Console.ReadLine();
            for (int i =cumle.Length-1; i>=0; i--)
            {
                terscumle += cumle[i];
            }
            Console.WriteLine(terscumle);
            Console.ReadKey();
        }
    }
}
