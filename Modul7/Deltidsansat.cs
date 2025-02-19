namespace Modul7;

public class Deltidsansat: Ansat
{
    public int Timer { get; set; }
    public double Timeløn { get; set; }

    public override double BruttoLøn()
    {
        return Timer * Timeløn;
    }
}