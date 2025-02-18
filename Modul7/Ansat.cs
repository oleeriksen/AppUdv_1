namespace Modul7;

public class Ansat
{
    public string Navn { get; set; } = String.Empty;
    public string Adresse { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public int Fradrag { get; set; }
    public double TrækProcent { get; set; }
    public bool FrokostOrdning { get; set; }
    public bool GaveOrdning { get; set; }
}