using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            float resultado = 0;

            Console.WriteLine("Digite a operação que deseja fazer \n Soma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º valor");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º valor");
            float num2 = float.Parse(Console.ReadLine());

            switch (operacao)
            {
                case "Soma":
                resultado = num1+num2;
                    break;

                case "Subtracacao":
                resultado = num1-num2;
                    break;

                case "Multiplicacao":
                resultado = num1*num2;
                    break;

                case "Divisao":
                resultado = num1/num2;
                    break;
                    
                default:
                    Console.WriteLine("Operação inválida");
                    break;       
            }
            
            Console.WriteLine($"Calculo: {num1} e {num2} - Resultado : {resultado}");
        }
    }
}
