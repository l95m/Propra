/* Erstellen Sie ein C# Programm, welches folgende Aufgabenstellung löst:
Ein Spieler kann ich in einem zweidimensionalen Raum in alle Himmelsrichtungen (Norden „N“,
Süden „S“, Osten „O“ und Westen „W“) bewegen. Entwickeln Sie einen Algorithmus, der für eine
beliebe Bewegungseingabe ausgibt, ob der Spieler wieder am Start steht.
Beispiel:
„SNOW“: Wahr
„SNWW“: Falsch
„SNNWOWOS“: Wahr
„OWOWOOWSNS“: Falsch
*/

public class BewegungImRaum
{

    public static void Main(string[] Args)
    {
        BewegungImRaum b = new BewegungImRaum();
        b.Bewegen();
    }

    public int x = 0, y = 0;

    public bool Bewegen()
    {
        Console.WriteLine("Enter directions: ");                        //input
        string input = Console.ReadLine();
        string[] arr = input.Split('\u002C');                           //String Array für einfachere weitere Arbeit


        for (int i = 0; i < arr.Length; i++)                            //Koordinaten berechnen
        {
            if (arr[i].Equals("S"))
            {
                x -= 1;
            }

            else if (arr[i].Equals("N"))
            {
                x += 1;
            }

            else if (arr[i].Equals("O"))
            {
                y += 1;
            }

            else if (arr[i].Equals("W"))
            {
                y -= 1;
            }
            
            else
            {
                Console.WriteLine("Your input should be in capital letters! (e.g 'SOWNOS') Try again!");
            }
        }

        if (x == 0 && y == 0)                                           //Koordinaten vergleichen
        {
            Console.WriteLine("You are where you started");
            return true;
        }

        else
        {
            Console.WriteLine("You are lost");
            return false;
        }
    }
}

/* Andere Ideen:
 * Buchstaben zählen -> Anzahl S = Anzahl N && Anzahl W = Anzahl O
 * 