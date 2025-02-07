namespace Modul3;

public class Opgave2
{
    public void Run()
    {
        int[] tal;
        int antal = ReadInt("Indtast antal karaktere: ");
        tal = new int[antal];
        for (int i = 0; i < tal.Length; i++)
            tal[i] = ReadInt($"Indtast karakter nr {i+1}:");
        Console.WriteLine($"Gennemsnit er: {Average(tal)}");
        int[] grades = { -3, 0, 2, 4, 7, 10, 12 };

        foreach (int aGrade in grades)
        {
            int cc = Count(tal, aGrade);
            if (cc > 0)
                Console.WriteLine($"Antal af {aGrade} er {cc}");
        }


    }

    int ReadInt(string prefix = "")
    {
        Console.Write(prefix);
        return int.Parse(Console.ReadLine());
    }
    
    //Returnerer gennemsnittet af tallene i a - NIY
    double Average(int[] a)
    {
        double sum = 0;
        foreach (int value in a)
            sum += value;
        return sum/a.Length;
    }

    int Count(int[] a, int key)
    {
        int result = 0;
        foreach (int value in a)
            if (value == key)
                result++;
        return result;
    }

}