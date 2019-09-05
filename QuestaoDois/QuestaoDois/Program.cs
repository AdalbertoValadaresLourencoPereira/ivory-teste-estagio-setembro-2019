using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara a variável nome do tipo string.
            string nome;

            //Solicitação da informação para o usuário e atribibui o valor na variável. 
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            // Chamada do método imprimirMatriz passando como parametro, a variavel nome.
            imprimirMatriz(nome);
            Console.ReadKey();

        }

        // Criação e execução do método imprimirMatriz.
        static void imprimirMatriz(String nome)
        {
            // Declara a variavel colunaMatriz com base na quantidade de caracteres presente na string lida.
            int colunaMatriz = (nome.Length + 2);

            // Cria uma matriz com 3 linhas, e o numero de colunas, altera com base na variavel nome.
            string[,] MatrizNome = new string[3, colunaMatriz];

            // Separa o conteudo de nome, por char.
            var chars = nome.ToCharArray();

            // Preenche a 2º linha da matriz, com os caracteres da variavel nome, a partir da posição [1,0], até finalizar a palavra. 
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {               
                MatrizNome[1, ctr+1] =Convert.ToString(chars[ctr]);
            }

            // Laço para preencher as posições restantes da matriz.
            for (int i = 0; i < colunaMatriz; i++)
            {
                int j = (colunaMatriz * 2 + 1);

                while (i < colunaMatriz)
                {
                    // Preeche a primeira linha da matriz de forma sequencial, usando os valores do contador 'i'.
                    MatrizNome[0, i] =  Convert.ToString(i + 1);

                    // Preeche a primeira posição da 2º linha da matriz, onde temos o inicio da variavel nome, de acordo com ( 3 * Nº de colunas + 2 - Nº de colunas  )
                    MatrizNome[1, 0] =  Convert.ToString(3 * colunaMatriz + 2 - colunaMatriz) ;

                    // Preeche a ultima posição da 2º linha da matriz, onde temos o ultimo caractere da variavel nome,com base no numero de colunas - 1.
                    MatrizNome[1, colunaMatriz - 1] =  Convert.ToString(i + 2) ;


                    // Preeche a terceira linha da matriz de forma sequencial, usando os valores do contador 'j', que é calculado por  2 * Nº de colunas + 1.
                    MatrizNome[2, i] = Convert.ToString(j) ;
                    i++;
                    j = j - 1;
                }

            }

            // Imprime a matriz de forma automática, apos chegar no numero de colunas, é feito uma quebra de linha, passando para proxima linha.
            for (int i = 0; i < 3; i++)
            {
                // percorer linha

                for (int x = 0; x < colunaMatriz; x++)
                {
                    // percorrer coluna
                    Console.Write("[{0,-5:N1}]", MatrizNome[i, x]);

                }

                Console.Write("\n");

            }

        }
    }
}