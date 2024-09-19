// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar o primeiro número
        Console.Write("Digite o primeiro número: ");
        double primeiroNumero = Convert.ToDouble(Console.ReadLine());

        // Solicitar o segundo número
        Console.Write("Digite o segundo número: ");
        double segundoNumero = Convert.ToDouble(Console.ReadLine());

        // Realizar a soma
        double resultado = primeiroNumero + segundoNumero;

        // Exibir o resultado
        Console.WriteLine($"A soma de {primeiroNumero} e {segundoNumero} é {resultado}.");

        // Manter o console aberto
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}