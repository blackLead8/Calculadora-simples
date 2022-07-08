using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

        Inicio:
            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação que deseja realizar: + - X /");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            { 
                default:
                    Console.WriteLine("Operação invalida: ");
                    break;
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;
                case 'X':
                case 'x':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação: " + resultado);
                    break;
                case '/':
                case ':':

                    if(num2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por 0: ");
                        
                    }
                    else
                    {
                        resultado = resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão: " + resultado);
                            
                    }

                    break;   
            }

            Console.Write("Continuar calculando (s / n )? ");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }         

            

        }
    }
}
