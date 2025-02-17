namespace Modul3;

public class Diverse
{
    public void Run()
    {
        int[] a = { 12, 34, 12, 34, 56 };

        int[] b = new int[12];

        foreach (int v in a)
        {
            Console.WriteLine(v);
        }

        b[0] = 1;
        for (int i = 1; i < b.Length; i++)
            b[i] = 2 * b[i - 1];
        
        foreach (int v in b)
            Console.WriteLine(v);
    }

    public void Run2()
    {
        List<int> a = new() { 12, 34, 12, 34, 56 };

        foreach (int v in a)
        {
            Console.WriteLine(v);
        }

        List<int> b = new() { 1 };

       
        for (int i = 1; i < 12; i++)
            b.Add(2 * b[i - 1]);

        foreach (int v in b)
            Console.WriteLine(v);
    }
}