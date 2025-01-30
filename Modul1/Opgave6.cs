namespace Modul1;

public class Opgave6
{
    public static void Run() {
        for (int i = 0; i < 10; i++) {
            string output = "";
            // lav 10-i blanke
            for (int j = 0; j < 10 - i - 1; j++)
            {
                output += "_";
            }

            // lav i+1 stjerner
            for (int j = 0; j < i + 1; j++)
            {
                output += "*";
            }

            Console.WriteLine(output);
        }
    }
}