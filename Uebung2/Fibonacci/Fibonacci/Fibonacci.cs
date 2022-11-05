/*
 *  Erstellen Sie ein C# Programm welches die Fibonacci-Folge bis einschließlich 55 mithilfe von
Schleife(n) in der Konsole ausgibt.

0,1,1,2,3,5,8 usw.
 */

public class Fibonacci
{
    public static void Main(string[] args)
    {
        int zahl1 = 1, zahl2 = 1, fib = 0;

        Console.Write(zahl1 + ", " + zahl2);

        for (int i = 0; fib < 55; i++)
        {
            fib = zahl1 + zahl2;
            zahl1 = zahl2;
            zahl2 = fib;
            Console.Write(", "+ fib);
        }

    }


}