namespace Modul7;

public class Test1
{
    void T1()
    {
        Deltidsansat peter = new Deltidsansat
        {
            Navn = "Peter", Adresse = "byvej 1, 1234 By", Email = "peter@mail.dk",
            Fradrag = 4000, TrækProcent = 38, FrokostOrdning = true, GaveOrdning = false, 
            Timeløn = 123, Timer = 12
        };
        Fuldtidsansat thomas = new Fuldtidsansat
        {
            Navn = "Thomas", Adresse = "svinget 4, 4321 Rundby", Email = "th@mail.dk",
            Fradrag = 7000, TrækProcent = 43, FrokostOrdning = true, GaveOrdning = true,
            Månedsløn = 34000
        };
        
        
    }
}