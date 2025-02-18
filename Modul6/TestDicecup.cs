namespace Modul6;

public class TestDicecup
{
    private DiceCup dc = new();

    public void Run()
    {
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