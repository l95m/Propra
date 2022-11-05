using System.IO;

public class TabellenAuslesen
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Wieviele Punkte werden zum bestehen benötigt?");
        int Punktzahl = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Punktzahl);                                          //Kontrolle


        TabellenAuslesen t = new TabellenAuslesen();
        t.Auslesen(Punktzahl);

    }


    public void Auslesen(int Punktzahl)
    {
        using (StreamReader sr = new StreamReader("Klausur.csv"))
        {
            List<string> MatrNr = new List<string>();
            List<int> Punkte = new List<int>();

            sr.ReadLine();                                                      //Erste Zeile gesonsert

            while (!sr.EndOfStream)
            {                                                
                var line = sr.ReadLine();
                var values = line.Split(";");

                MatrNr.Add(values[0]);
                Punkte.Add(Convert.ToInt32(values[1]));
            }



            Console.WriteLine("Bestanden: ");

            for (int i = 0; i  <= Punkte.Count; i++)
            {
                if (Punkte[i] >= Punktzahl)
                {
                    Console.Write(MatrNr[i] + ", ");
                }
            }
        }




    }

}
