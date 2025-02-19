namespace Modul7;

public class TestDiceCup
{
    public static void Run()
    {
        DiceCup dc = new();
        for (int i = 0; i < 10; i++)
        {
            dc.Shake();
            int[] eyes = dc.GetEyes();
            foreach (int e in eyes)
                Console.Write($" {e}");
            Console.WriteLine();

        }
    }
}