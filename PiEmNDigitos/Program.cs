/* PROGRAMA: Número PI em N casas decimais
 * Autor: Diogo Zimmermann
 * Data: 19/12/2019
 * 
 * O programa mostra o número PI com um número 
 * determinado pelo usuário de casas decimais.
 * 
 */

using System;

namespace PiEmNDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor (Entre 1 e 15)");
            try
            {
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI, value));
            }

            catch (Exception)
            {
                Console.WriteLine("Digite um valor entre 1 e 15!");
            }
          
        }

    }
}
