using Modul5;

namespace Modul7;

public class TestMafia
{
    public static void Run()
    {
        MafiaDice d = new MafiaDice();

        int[] count = new int[6];
        // antal x'ere ligger i count[x-1]

        long N = 100000;

        for (long i = 0; i < N; i++) {
            d.Roll();
            int idx = d.GetEyes() - 1;
            count[idx]++;
        }

        for (int idx = 0; idx < 6; idx++)
            Console.WriteLine($"Antal {idx+1}'ere: {count[idx]}");
    }
}
