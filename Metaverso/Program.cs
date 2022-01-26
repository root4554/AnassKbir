using System;

namespace Metaverso
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();

            Console.WriteLine(sistema.Comprobacionnumero(15));

            int[] listNumeros ={3,15};
            Console.WriteLine(sistema.Comprobacionarray(listNumeros));
        }
    }
}
