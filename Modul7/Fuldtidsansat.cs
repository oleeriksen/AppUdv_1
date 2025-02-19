namespace Modul7;

public class Fuldtidsansat : Ansat
{
    public double Månedsløn { get; set; }

    public override double BruttoLøn()
    {
        return Månedsløn;
    }
}