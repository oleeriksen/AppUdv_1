using Modul5;

namespace Modul6;

public class Dicecup1
{
    private Dice mdice1;
    private Dice mdice2;

    public Dicecup1()
    {
        mdice1 = new();
        mdice2 = new();
    }

    public void Shake()
    {
        mdice1.Roll();
        mdice2.Roll();
    }

    public int[] GetEyes()
    {
        return new int[] { mdice1.GetEyes(), mdice2.GetEyes() };
    }
}