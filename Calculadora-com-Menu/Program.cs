using System;

class CalculadoraComMenu
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo à Calculadora!");
        Console.WriteLine("Digite [1] para iniciar e [2] para sair.");
        int inicio = Convert.ToInt32(Console.ReadLine());
        while (inicio == 1) /
        {
            Console.WriteLine("\n<----------- CALCULADORA ----------->");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("[1] - Somar");
            Console.WriteLine("[2] - Subtrair");
            Console.WriteLine("[3] - Multiplicar");
            Console.WriteLine("[4] - Dividir");
            Console.WriteLine("Digite 'sair' para encerrar.");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine().ToLower();

            if (opcao == "sair")
            {
                Console.WriteLine("Encerrando a calculadora...");
                break;
            }

            float num1, num2;
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                case "2":
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                case "3":
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                case "4":
                    if (num2 != 0)
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    else
                        Console.WriteLine("Erro: Divisão por zero não permitida.");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
