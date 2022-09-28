using System;

namespace Exemplo_contador
{
    class Program
    {
        static void Main(string[] args)
        {
            // =========== CONTADOR BASICO =============
            /*int soma = 0;
            // inicializar | condição | atualização
            for (int i = 1; i < 51; i++)
            {
                // soma = soma + 1 ou...
                soma += i;
                // Console.WriteLine($"Numero: {i}"}
            }
            Console.WriteLine(soma); */

            // =========== CONTADOR DE TABUADA =========
            /* int t;
            for (t = 1; t <= 10; t++)
            {
                int t1 = t * 5;
                Console.WriteLine($"Tabuada do 5 x {t} = {t1}");
            } */

            // =========== CONTADOR INTRODUZIDO ==========
            int num, a;
            Console.WriteLine("Insira um numero");
            num = Convert.ToInt32(Console.ReadLine());
            for (a =1; a <=10; a++)
            {
                int resultado = num * a;
                Console.WriteLine($"Tabuada: {num} x {a} = {resultado}");
            }
            
        } 
    }
}
