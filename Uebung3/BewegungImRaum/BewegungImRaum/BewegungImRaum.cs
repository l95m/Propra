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


    public bool Bewegen()
    {
        Console.WriteLine("Enter directions: ");                            //input
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();


        int s = 0, n = 0, w = 0, o = 0, b = 0;                            // BS COUNTER B

        for (int i = 0; i < arr.Length; i++)                              //Koordinaten berechnen
        {
            if ((arr[i].ToString()).Equals("S"))
            {
                s += 1;
            }

            else if ((arr[i].ToString()).Equals("N"))
            {
                n += 1;
            }

            else if ((arr[i].ToString()).Equals("O"))
            {
                o += 1;
            }

            else if ((arr[i].ToString()).Equals("W"))
            {
                w += 1;
            }

            else
            {
                Console.WriteLine("ONLY 'S', 'N', 'O', 'W'!");
                b += 1;
                break;
            }
        }

        if (s == n && o == w && b == 0)                                           //Koordinaten vergleichen
        {
            Console.WriteLine("You are where you started");
            return true;
        }

        else if (b == 0)
        {
            Console.WriteLine("You are lost");
            return false;
        }

        else
        {
            return false;
        }
    }
}