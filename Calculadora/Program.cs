using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main()
        {
            // variáveis usadas para o programa
            float numero1;
            float numero2;
            float resultado;
            char operacoes;

            Console.WriteLine("BEM VINDO A SUA CALCULADORA!");
            Console.WriteLine("Digite o primeiro numero: ");
            while (!float.TryParse(Console.ReadLine(), out numero1)) // Enquanto oque for colocado for diferente de um numero, da erro e retorna a mesma pergunta até o usuario digitar um numero
            {
                Console.WriteLine("Entrada invalida para a calculadora, por favor insira um numero valido!");
            }
            Console.WriteLine("Digite o segundo numero: ");
            while (!float.TryParse(Console.ReadLine(),out numero2)) // A mesma coisa acontece aqui, caso o usuario coloque algo que não seja um numero, entra em loop até sair um numero.
            {
                Console.WriteLine("Entrada invalida para a calculadora, por favor insira um numero valido!");
            }
            Console.WriteLine("Escolha o operador: (+ , - , * , / )");
            operacoes = Console.ReadKey().KeyChar; // necessario para ler o caractere

            Console.WriteLine(); // pular linha

            resultado = (numero1 + numero2);
            /*
             Aqui dependendo do caso que o usúario escolher 
             um desses casos abaixo irá acontecer
             */
            switch (operacoes)
            {
                case '+': // caso de soma
                    resultado = numero1 + numero2;
                    Console.WriteLine($"O resultado de {numero1} + {numero2} é {resultado}");
                break;
                case '-': // caso de subtração
                    resultado = numero1 - numero2; 
                    Console.WriteLine($"O resultado {numero1} - {numero2} é {resultado}");
                    break;
                case '*': // caso de multiplicação
                    resultado = numero1 * numero2;
                    Console.WriteLine($"O resultado de {numero1} * {numero2} é {resultado}");
                    break;
                case '/': // caso de divisão
                    if ( numero2 != 0 ) // uso de estrutura de decisão IF para ver se o segundo numero é difente de zero
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"O resultado de {numero1} / {numero2} é {resultado}"); // se for, a divisão ocorrerá normalmente
                    }
                    else
                    {
                        Console.WriteLine("Numero divisivel por zero não pode!"); // se não, retorna erro
                    }
                    break;
                    default:
                    Console.WriteLine("Operação invalida!");
                    break;  
            }

            Console.WriteLine("Fim da Calculadora :)");
            Console.ReadLine();
        }
    }
}
