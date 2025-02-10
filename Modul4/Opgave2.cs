using System;
namespace Modul4
{
    public class Opgave2
    {
        public void Run()
        {
            List<int> tal = new();
            Console.Write("Indtast karaktere (stop ved at skrive stop): ");

            while (true) {
                string input = Console.ReadLine();
                if ( input.ToLower() == "stop" )
                    break;
                int aGrade = int.Parse(input);
                tal.Add(aGrade);
            }
         
            Console.WriteLine($"Gennemsnit er: {Average(tal.ToArray())}");
            int[] grades = { -3, 0, 2, 4, 7, 10, 12 };

            foreach (int aGrade in grades)
            {
                int cc = Count(tal, aGrade);
                if (cc > 0)
                    Console.WriteLine($"Antal af {aGrade} er {cc}");
            }


        }

        //Returnerer gennemsnittet af tallene i a - NIY
        double Average(int[] a)
        {
            double sum = 0;
            foreach (int value in a)
                sum += value;
            return sum / a.Length;
        }

        int Count(List<int> a, int key)
        {
            int result = 0;
            foreach (int value in a)
                if (value == key)
                    result++;
            return result;
        }

    }
}

