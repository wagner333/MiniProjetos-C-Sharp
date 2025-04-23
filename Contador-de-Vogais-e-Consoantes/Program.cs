using System;

class Contador{
    public static void Main(string[] args){
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();
        int vogais = 0;
        int consoantes = 0;

        foreach (char letra in frase.ToLower()){
            if ("aeiou".Contains(letra)){
                vogais++;
            }else if (char.IsLetter(letra)){
                consoantes++;
            }
        }

        Console.WriteLine($"Número de vogais: {vogais}");
        Console.WriteLine($"Número de consoantes: {consoantes}");
}
