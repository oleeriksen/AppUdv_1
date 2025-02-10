using System;
namespace Modul5
{
    public class TestDice
    {
        public void Run() {
            Dice d = new();

            for (int i = 0; i < 1000; i++)
            {
                d.Roll();
                Console.WriteLine($"dice v1 - {d.GetEyes()}");
            }
        }
    }
}

