using System;

class Media{
    public static void Main(string[] args){
        Console.WriteLine("Digite a primeira nota: ");
        float nota1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        float nota2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota: ");
        float nota3 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Digite a quarta nota: ");
        float nota4 = Convert.ToSingle(Console.ReadLine());

        float media = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine("A média é: " + media);

        if (media >= 7)
            Console.WriteLine("Aprovado!");
        else if (media >= 5)
            Console.WriteLine("Recuperação!");
        else
            Console.WriteLine("Reprovado!");
    }
}