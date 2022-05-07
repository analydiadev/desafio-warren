namespace CShp_StringReverse
{
    public class Program
    {
        public const int QuantidadeLimite = 1000000;
        public const int VerificarSeEImpar = 2;
        public const int CalculoReverterONumero = 10;
        
        private static void Reverte(int numero)
        {
            int aux, reverso = 0;
            int numeroNormal = numero;

            while (numero > 0)
            {
                aux = numero % CalculoReverterONumero;
                reverso = (reverso * CalculoReverterONumero) + aux;
                numero /= CalculoReverterONumero;

            }

            int resultado = numeroNormal + reverso;
            if (resultado % VerificarSeEImpar != 0 && resultado < QuantidadeLimite)
            {
                Console.WriteLine($"{numeroNormal} + {reverso} = {resultado}");
            }
        }

        private static void LoopDeSoma() 
        {
            for (int i = 10; i < QuantidadeLimite; i++)
            {
                Reverte(+i);
            }
        }
        public static void Main(string[] args)
        {
            LoopDeSoma();
            Console.ReadKey();
        }
    }
}
