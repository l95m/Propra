using System;

public class BodyMassIndex
{
    static void Main(string[] args)
    {
        BodyMassIndex b = new BodyMassIndex();
        
        b.Ausrechnen();
    }


    public void Ausrechnen()
    {
        Console.WriteLine("Enter Weight in Kg (For example '68,4'): ");                                             //Weight Abfrage
        Double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Size in m (For example '1,78'): ");                                                //Size Abfrage
        Double size = Convert.ToDouble(Console.ReadLine());

        Double bmi = Math.Round(weight / (size * size), 2);                                                         //BMI ausrechnen und auf 2 Nachkommastellen runden
        Console.WriteLine(bmi);

        Console.WriteLine("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter gender ('male' or 'female'): ");
        string gender = Console.ReadLine();

        string result;

        if (age < 18 || age > 90)
        {
            Console.WriteLine("Don't worry about your BMI. You're either too old (>90) or too young (<18) for that :)");
        }

        else
        {
            switch (gender)                                                                                         //BMI einordnen
            {
                case "male":
                    if (age >= 18 && age <= 24)                                                                     //Hard coded und schlecht aber sehe auch keine Pattern
                    {                                                                                               //Evtl. Zahlen ganz runden? Aber was ist mit den Zwischenräumen dann..
                        if (bmi < 19.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 19.5 && bmi <= 25.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 25.5 && bmi <= 29.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else if (age >= 25 && age <= 34)
                    {
                        if (bmi < 20.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 20.5 && bmi <= 26.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 26.5 && bmi <= 30.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else if (age >= 35 && age <= 44)
                    {
                        if (bmi < 21.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 21.5 && bmi <= 27.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 27.5 && bmi <= 31.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else if (age >= 45 && age <= 54)
                    {
                        if (bmi < 22.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 22.5 && bmi <= 28.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 28.5 && bmi <= 32.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else if (age >= 55 && age <= 64)
                    {
                        if (bmi < 23.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 23.5 && bmi <= 30)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 30 && bmi <= 33.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else
                    {
                        if (bmi < 24.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 24.5 && bmi <= 30.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 30.5 && bmi <= 34.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    Console.WriteLine("Your BMI is " + bmi + ". Result: " + result);
                    break;

                case "female":
                    if (age >= 18 && age <= 24)
                    {
                        if (bmi < 18.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 18.5 && bmi <= 24.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 24.5 && bmi <= 28.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else if (age >= 25 && age <= 34)
                    {
                        if (bmi < 19.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 19.5 && bmi <= 25.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 25.5 && bmi <= 29.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else if (age >= 35 && age <= 44)
                    {
                        if (bmi < 20.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 20.5 && bmi <= 26.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 26.5 && bmi <= 30.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else if (age >= 45 && age <= 54)
                    {
                        if (bmi < 21.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 21.5 && bmi <= 27.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 27.5 && bmi <= 31.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else if (age >= 55 && age <= 64)
                    {
                        if (bmi < 22.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 22.5 && bmi <= 29)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 29 && bmi <= 32.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }

                    else
                    {
                        if (bmi < 23.5)
                        {
                            result = "Underweighed!";
                        }

                        else if (bmi >= 23.5 && bmi <= 29.5)
                        {
                            result = "Your weight is normal!";
                        }

                        else if (bmi > 29.5 && bmi <= 33.5)
                        {
                            result = "Slightly overweighed";
                        }

                        else
                        {
                            result = "Overweighed!";
                        }
                    }


                    Console.WriteLine("Your BMI is " + bmi + ". Result: " + result);
                    break;

                default:
                    Console.WriteLine("Enter 'male' or 'female' next time. Your BMI is " + bmi + " though!");
                    break;
            }
        }

    }
}
