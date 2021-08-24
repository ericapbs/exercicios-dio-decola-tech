/*Desafio
Desenvolva um programa capaz de ler três valores e apresentar o maior deles e adicionar a mensagem “ eh o maior”. Use a seguinte forma como base:

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido pela mensagem " eh o maior".*/

using System;

namespace Dio.Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, MAIORAB, MAIOR;
            
            string[] valores = Console.ReadLine().Split(' ');
            
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            MAIORAB = (A + B + Math.Abs(A - B))/ 2;

            MAIOR = (MAIORAB + C + Math.Abs (MAIORAB - C))/ 2;
            
            Console.WriteLine(MAIOR + " eh o maior");
            //Console.WriteLine($"{MAIOR} eh o maior");
            Console.ReadLine();
        }
    }
}
