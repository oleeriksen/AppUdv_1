namespace Modul1;

public class Opgave2
{
    public void Run()
    {
        Console.Write("Opg 2: Indtast et tal: ");
        int antal = int.Parse(Console.ReadLine());

        while (antal >= 1)
        {
            Console.WriteLine(antal);
            antal--;
        }
    }
}