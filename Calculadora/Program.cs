using Calculadora.Enums;
using Calculadora.Exceptions;
using System;

namespace Calculadora
{
    class Program
    {
        static void ImprimeOperacoes()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha a operacao a ser realizada: ");
            Console.WriteLine();
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");
            Console.Write("Digite aqui a operacao: ");
        }
        
        static void Main(string[] args)
        {
            decimal numero1, numero2, resultado;
            OperacaoCalculadoraEnum operacao;
            try
            {

                Console.WriteLine("Bem vindo a sua calculadora de operacoes basicas!!!");
                Console.Write("Digite o primeiro numero da operacao: ");
                numero1 = decimal.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero da operacao: ");
                numero2 = decimal.Parse(Console.ReadLine());
                Calculadora calculadora = new CalculadoraBasica(numero1, numero2);

                ImprimeOperacoes();

                operacao = Enum.Parse<OperacaoCalculadoraEnum>(Console.ReadLine());
                Console.WriteLine();

                resultado = calculadora.ExecutaOperacao(operacao);

                Console.WriteLine($"O resultado da {operacao} entre {numero1} e {numero2} = {resultado}");
            }
            catch (FormatException e)
            {

                Console.WriteLine($"Entrada de dados invalida: {e.Message}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Erro durante a operacao: {e.Message}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Erro ao selecionar a opcao: {e.Message}");
            }
            
        }
    }
}
