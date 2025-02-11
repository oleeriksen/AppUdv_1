using System;
namespace Modul5
{
    public class Opgave_1
    {
        public void Run() {
            Dice d = new();

            int[] count = new int[6];
            // antal x'ere ligger i count[x-1]

            long N = 6000000000;

            for (long i = 0; i < N; i++) {
                d.Roll();
                int idx = d.GetEyes() - 1;
                count[idx]++;
            }

            for (int idx = 0; idx < 6; idx++)
                Console.WriteLine($"Antal {idx+1}'ere: {count[idx]}");
        }
    }
}

