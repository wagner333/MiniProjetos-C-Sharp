using System;
using System.Text.RegularExpressions;

class VerificaCPF
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o CPF (formato 000.000.000-00): ");
        string cpf = Console.ReadLine();
        string padrao = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";

        if (Regex.IsMatch(cpf, padrao))
        {
            Console.WriteLine("CPF com formato válido!");
        }
        else
        {
            Console.WriteLine("Formato inválido! Use o formato 000.000.000-00.");
        }
    }
}
