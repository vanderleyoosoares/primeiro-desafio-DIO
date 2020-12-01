using System;

namespace Testes
{
    class Desafio 
        {
            static void Main(){
                Console.WriteLine(" Insíra o numero de Operações que serão feitas:");
                int limit = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < limit; i++) 
                {
                    Console.WriteLine(" Insíra os 2 numeros a serem divididos separados por / (ex: 10/2 ) :");
                    Console.WriteLine();
                    string[] line = Console.ReadLine().Split("/");
                    double X = double.Parse(line[0]);
                    double Y = double.Parse(line[1]);
                    if (Y == 0){
                        Console.WriteLine("divisao impossivel");
                    } else{
                        Console.WriteLine();
                        Console.WriteLine(" O Valor da divisão é:");
                        double divisao = X / Y; // Digite aqui o calculo da divisao
                        Console.WriteLine(divisao.ToString("N1"));
                        Console.WriteLine();
                    }
                }
            }
        }
}