namespace Modul1;

public class Opgave4
{
    public void Run()                             
    {                                             
        Console.Write("Opg 4: Indtast et tal: "); 
        int antal = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int x = 1; x <= antal; x++)
        {
            sum = sum + x;
        } 
        Console.WriteLine($" er: {sum}");
    }                                             
}