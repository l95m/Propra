/*
 * Erstellen Sie ein C# Programm welches ein Bankkonto simuliert. Implementieren Sie hierzu die Klasse
Konto (Abbildung 1). Überprüfen Sie beim Auszahlen ob die Auszahlung möglich ist.
Erstellen Sie mehrere Konten und nehmen Sie verschiedene Buchungen (Einzahlungen und
Auszahlungen) auf diesen vor. Geben Sie zum Schluss aus, welches Konto (Kontonummer) welchen
Betrag hat.

Attr:
Nummer : int
Betrag : float

Funktionen:
Einzahlen (wert:float) : void
Auszahlen (wert: float) : bool

*/



public class Konto
{
    public static void Main(string[] args)
    {
        Konto a = new Konto();
        a.Nummer = 1234;
        a.Einzahlen((float)6.06);
        a.Auszahlen(7);                                                         //Sollte nicht funktionieren
        a.Auszahlen(4);
        Console.WriteLine("Konto: " + a.Nummer + " Wert: " + a.Betrag);

        Konto b = new Konto();
        b.Nummer = 12345678;
        b.Betrag = 400;
        b.Einzahlen((float)20.18);
        b.Auszahlen(19);
        Console.WriteLine("Konto: " + b.Nummer + " Wert: " + b.Betrag);
    }

    public int Nummer;
    public float Betrag;

    public void Einzahlen(float wert)
    {
        Betrag += wert;
    }

    public bool Auszahlen(float wert)
    {
        if (wert > Betrag)
        {
            return false;
        }
            
        else
        {
            Betrag -= wert;
            return true;
        }
    }


}