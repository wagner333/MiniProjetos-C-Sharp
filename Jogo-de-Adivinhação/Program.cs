using System;

class Jogo{
    public static void Main(string[] args){
        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");
        
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
        int tentativas = 0;
        int palpite = 0;

        while (palpite != numeroSecreto) {
            Console.Write("Digite seu palpite: ");
            palpite = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (palpite < numeroSecreto) {
                Console.WriteLine("Muito baixo! Tente novamente.");
            } else if (palpite > numeroSecreto) {
                Console.WriteLine("Muito alto! Tente novamente.");
            } else {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto} em {tentativas} tentativas.");
            }
        }
    }
}
