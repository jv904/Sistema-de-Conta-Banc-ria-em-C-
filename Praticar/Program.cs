using System;
using System.Globalization;
namespace Praticar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com titular da conta:");
            string titular = Console.ReadLine();

            ContaBancaria conta = new ContaBancaria(numero, titular);

            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("===MENU===");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - ver saldo");
                Console.WriteLine("0 - sair");

                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao) {

                    case 1:
                        Console.WriteLine("Você escolheu Depositar");
                        Console.WriteLine();

                        Console.Write("Entre um valor para depósito: ");
                        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Deposito(quantia);
                        Console.WriteLine("Dados da conta atualizados:");
                        Console.WriteLine(conta);
                        break;

                    case 2:
                        Console.WriteLine("Você escolheu Sacar");
                        Console.WriteLine();
                        Console.Write("Entre um valor para saque: ");
                        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Saque(quantia);
                        Console.WriteLine("Dados da conta atualizados:");
                        Console.WriteLine(conta);
                        break;

                    case 3:
                        Console.WriteLine("Dados da conta:");
                        Console.WriteLine(conta);
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != 0);
        }
        static double LerValorPositivo(string mensagem)
        {
            double valor;
            bool valido;

            do
            {
                Console.Write(mensagem);
                valido = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out valor);

                if (!valido || valor <= 0)
                {
                    Console.WriteLine("Valor inválido! Digite um número positivo.\n");
                }

            } while (!valido || valor <= 0);

            return valor;
        }
    }
}
    
