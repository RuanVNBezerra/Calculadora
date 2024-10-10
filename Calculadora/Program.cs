using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main()
        {
            // variáveis usadas no programa
            float numero1;
            float numero2;
            float resultado;
            char operaçoes;
            string input;

            Console.WriteLine("BEM VINDO A SUA CALCULADORA!");

            while (true) // laço de repetição que mantem o programa rodando até o usuario decidir sair.
            {
                Console.WriteLine("Digite o primeiro numero: (Ou digite 'sair' para encerrar o programa) ");
                input = Console.ReadLine();
                if (input.ToLower() == "sair") // caso o usuario digite "sair" minusculo ou maiusculo, o programa encerra.
                {
                    break;
                }
                while (!float.TryParse(input, out numero1)) // Enquanto oque o usuario não digitar um numero, o programa ficara em loop até um numero ser inserido.
                {
                    Console.WriteLine("Erro na entrada, por favor digite um numero valido");
                    input = Console.ReadLine();

                    if (input.ToLower() == "sair") // verifica denovo se o usuario deseja encerrar o programa 
                    {
                        break;
                    }
                }
                // O mesmo acontece ao pedir o segundo numero, caso o usuario digite "sair" o programa encerra.
                Console.WriteLine("Digite o segundo numero: (Ou digite 'sair' para encerrar o programa)");
                input = Console.ReadLine();
                if (input.ToLower() == "sair")
                {
                    break;
                }

                while (!float.TryParse(input, out numero2))
                {
                    Console.WriteLine("Erro na entrada, por favor digite um numero valido");
                    input = Console.ReadLine();
                    if (input.ToLower() == "sair")
                    {
                        break;
                    }
                }

                Console.WriteLine("Selecione a operação que deseja (+ , - , * , /)");
                operaçoes = Console.ReadKey().KeyChar; // le o caractere que o usuario digitar

                Console.WriteLine(); // pular linha

                /*
               Aqui dependendo do caso que o usúario escolher 
               um desses casos abaixo irá acontecer
               */

                switch (operaçoes)
                {
                    case '+': // caso de soma
                        resultado = numero1 + numero2;
                        Console.WriteLine($"A soma de {numero1} + {numero2} é {resultado}");
                        break;
                    case '-': // caso de subtração
                        resultado = numero1 - numero2;
                        Console.WriteLine($"A subtração de {numero1} - {numero2} é {resultado}");
                        break;
                    case '*': // caso de multiplicação
                        resultado = numero1 * numero2;
                        Console.WriteLine($"A multiplicação de {numero1} * {numero2} é {resultado}");
                        break;
                    case '/': // caso de divisão
                        if (numero2 != 0) // se o numero dois for diferente de zero, o calculo é feito normalmente
                        {

                            resultado = numero1 / numero2;
                            Console.WriteLine($"A divisão de {numero1} / {numero2} é {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("ERRO! numero divisivel por zero não é permitido");
                        }
                        break;
                    default:
                        Console.WriteLine("ERRO! operação invalida!");
                        break;

                }

                Console.WriteLine(); // nova linha para a segundo calculo e em diante
            }

            Console.WriteLine("FIM DA CALCULADORA :) ");
            Console.WriteLine();
        }
    }
}