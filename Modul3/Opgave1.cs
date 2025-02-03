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
        return -1;
    }

//Returnerer variansen af tallene i a - NIY
    double Varians(int[] a)
    {
        return -2;
    }

//Returnerer standardafvigelsen af tallene i a - NIY
    double Deviation(int[] a)
    {
        return -3;
    }




}