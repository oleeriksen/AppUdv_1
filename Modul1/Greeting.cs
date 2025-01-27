namespace Modul1;

public class Greeting
{
    public void Run()
    {
        Console.Write("Skriv dit navn:");
        string name = Console.ReadLine();
        DateTime now = DateTime.Now;
        int hour = now.Hour;
        if (hour < 11)
        {
            Console.WriteLine($"Godmorgen {name}, håber du får en god dag");
        }
        else
        {
            if (hour <= 17)
                Console.WriteLine($"God eftermiddag {name}, håber du får en god eftermidddag");
            else
            {
                Console.WriteLine($"God aften {name} - du skal snart i seng...");
            }
        }
    }
}