using System;

class Program { static void Main() { int alegria = 0; int tristeza = 0;

        Console.WriteLine("Riley fez novas amizades na cidade? Quantas amizades ela fez?");
        int amizades = int.Parse(Console.ReadLine());

        if (amizades > 0)
        {
            alegria += amizades * 10;
        }
        else
        {
            tristeza += 30;
        }

        Console.WriteLine("Digite a nota da prova A1:");
        double a1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota da prova A2:");
        double a2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota da prova A3:");
        double a3 = double.Parse(Console.ReadLine());

        double media = (a1 + a2 + a3) / 3.0;

        if (media >= 7)
        {
            alegria += 50;
        }
        else
        {
            tristeza += 50;
        }

        Console.WriteLine("Riley tem 10 algoritmos para resolver.");
        Console.WriteLine("Quantos exercicios ela conseguiu fazer?");
        int feitos = int.Parse(Console.ReadLine());

        if (feitos < 0) feitos = 0;
        if (feitos > 10) feitos = 10;

        alegria += feitos * 10;
        tristeza += (10 - feitos) * 10;

        if (alegria > tristeza)
        {
            Console.WriteLine("A mudança para a nova cidade foi uma experiência incrível para a Riley.");
        }
        else
        {
            Console.WriteLine("A mudança para a nova cidade foi uma experiência desagradável para a Riley.");
        }
    }

}
