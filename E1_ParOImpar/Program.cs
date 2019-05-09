using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int []{ 3,2,6,73,4,6,10,50};
            
            foreach (int n in numeros)
                Console.WriteLine("{0}, es {1}", n, EsPar(n)? "par" : "impar" );
                        
            Console.ReadLine();
        }

        public static bool EsPar(int numero)
        {
            if (numero % 2 == 0)
                return true;
            return false;
        }
    }
}
