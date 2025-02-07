using System.Xml;

namespace Modul3;

public class Opgave1
{
    public void Run()
    {
        int[] tal;
        int antal = ReadInt("Indtast antal tal: ");
        tal = new int[antal];
        for (int i = 0; i < tal.Length; i++)
            tal[i] = ReadInt("Indtast tal: ");
        Console.WriteLine("Her kommer lidt statistik");
        Console.WriteLine($"Gennemsnit: {Average(tal)}");
        Console.WriteLine($"Varians: {Varians(tal)}");
        Console.WriteLine($"St afvigelse: {Deviation(tal)}");


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

//Returnerer variansen af tallene i a - NIY
    double Varians(int[] a)
    {
        double avg = Average(a);
        double sum = 0;
        foreach (int value in a)
            sum += Math.Pow(value - avg, 2);
        return sum;
    }

//Returnerer standardafvigelsen af tallene i a - NIY
    double Deviation(int[] a)
    {
        double varians = Varians(a);
        return Math.Sqrt(varians);
    }




}