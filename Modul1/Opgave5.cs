namespace Modul1;

public class Opgave5
{
    public void Run()
    {
        Console.WriteLine("Opg5");
        int tal1 = int.Parse(Console.ReadLine());
        int tal2 = int.Parse(Console.ReadLine());
        char op = Console.ReadLine()[0];
        if (op == '+')
            Console.WriteLine($"Summen er {tal1+tal2}");
        else if (op == '*')
            Console.WriteLine($"Produktet er {tal1*tal2}");

    }
}