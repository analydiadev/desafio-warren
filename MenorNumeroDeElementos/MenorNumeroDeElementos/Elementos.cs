using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenorNumeroDeElementos
{
    public class Elementos
    {
        public static readonly int[] Arr = { 2, 3, 4 };
        public const int Numero = 10;
        public static void FiltrarDadosDuplicados()
        {
            Console.WriteLine($"{Numero}");

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 1; j < Arr.Length; j++)
                {
                    if (Arr[i] + Arr[j] == Numero)
                    {
                        Console.WriteLine($"[{Arr[i]},{Arr[j]}]");
                    }

                    else if (Arr[i] + Arr[j] + Arr[j] == Numero)
                    {
                        Console.WriteLine($"[{Arr[i]}, {Arr[j]}, {Arr[j]}]");
                    }

                }
            }
        }
        public static void Main(string[] args)

        {
            FiltrarDadosDuplicados();
        }



    }
}




