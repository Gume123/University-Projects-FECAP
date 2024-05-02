using System;
class Program
{
    public static void Main(string[] args)
    {
        int fichas = 100;
        Random random1 = new Random();
        int dado1 = random1.Next(1, 7);
        Random random2 = new Random();
        int dado2 = random2.Next(1, 7);
        char continua = 's';

        Console.WriteLine("Digite sua aposta (Aposta minima eh 10)");
        int aposta = int.Parse(Console.ReadLine());
        while (aposta != 0)
        {
            if (fichas > 10)
            {
                if (aposta >= 10)
                {
                    Console.WriteLine($"Seu numero de fichas eh {CheckWin(dado1, dado2, aposta, fichas)}!");
                    fichas = CheckWin(dado1, dado2, aposta, fichas);
                    Console.WriteLine("Deseja Continuar? (s/n)");
                    continua = char.Parse(Console.ReadLine());
                    if (continua == 's')
                    {
                        Console.WriteLine("Digite sua aposta (Aposta minima eh 10)");
                        aposta = int.Parse(Console.ReadLine());
                    }
                    else if (continua == 'n')

                        break;
                    else
                        Console.WriteLine("Opção invalida");
                }
            }
            else
            {
                Console.WriteLine("Fichas Insuficientes!");
            }
        }
    }
    public static int CheckWin(int sorteio1, int sorteio2, int sorte, int chances)
    {
        if (chances >= sorte)
        {
            if (sorteio1 + sorteio2 == 7)
            {
                return chances += sorte * 2;
            }
            else if (sorteio1 + sorteio2 == 2 || sorteio1 + sorteio2 == 12)
                return chances += sorte * 3;
            else
                return chances -= sorte;
        }
        else if (chances == 0)
            return 0;
        else
            return 0;
    }
}