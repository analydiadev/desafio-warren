using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusAula.Main
{
    class Program
    {
        private static void StatusAula()
        {
            int limiteAlunos = 4;
            int[] horarioChegadaAlunos = { 0, 1, 2, 3, 4 };
            int chegadaHorario = Teste(horarioChegadaAlunos);

            if (chegadaHorario < limiteAlunos)
            {
                Console.WriteLine($"Aula Cancelada ");

            }
            else
            {
                Console.WriteLine("Aula Normal");
            }

        }
        private static int Teste(int[] horarioChegada)
        {
            int auxi = 0;

            foreach (int chegadaHorario in horarioChegada)
            {
                if (chegadaHorario <= 0)
                {
                    auxi++;
                }
            }
            return auxi;
        }
        public static void Main(string[] args)
        {
            StatusAula();

        }
    }
}