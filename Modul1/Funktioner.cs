namespace Modul1;

public class Funktioner
{
    public static void Run()
    {
        int[] a = { 1, 2, 4, 2, 3, 2};
        int resultat = FindAntal(a, 7);
        Console.WriteLine($"antal er {resultat}");
    }

    static int FindAntal(int[] a, int key)
    {
        int output = 0;
        int i = 0;
        while (i < a.Length)
        {
            if (key == a[i])
                output++;
            i = i + 1;
        }
        return output;
    }
}