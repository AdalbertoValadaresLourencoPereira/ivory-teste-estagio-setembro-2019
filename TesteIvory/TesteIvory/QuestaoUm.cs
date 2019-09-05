using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIvory
{
    class QuestaoUm
    {
        static void Main(string[] args)
        {

            int numero = 5;
            int resultado;

            resultado = Calcular(numero);
            Console.WriteLine("Resultado: {0}", resultado);
            Console.ReadKey();
                     
        }
            
        static int Calcular(int numero)
        {
            int resultado;

            if(numero <= 1)
            {
                return (1);
            }
          
         resultado = numero * Calcular(numero - 1);
         return (resultado);
        }
    }
}
