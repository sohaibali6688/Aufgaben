using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            int auswahl , summe=0;
            string nochmal;
            
            do
            {
                Console.WriteLine("Auswahlmenü");
                Console.WriteLine("1: Summe der ganzen Zahlen von a bis b.");
                Console.WriteLine("2: Verflixte 7.");
                Console.WriteLine("3: °C in °F umrechnen.");

                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {

                    Console.WriteLine("Summe der ganzen Zahlen vom a bis b berechnen:");
                    Console.WriteLine("a:"); 
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("b:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    

                    for (int i = a; i <= b; i++)
                    {
                        summe = summe + i;
                    }
                    Console.WriteLine("Die Summe der ganzen Zahlen von " + a + " bis " + b + " ergibt " + summe);
                }
                else if (auswahl == 2)
                {
                    Console.WriteLine("obere Grenze geben:");
                    int zahl = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i < zahl; i++)
                    {
                        Console.WriteLine(i);
                        
                        if (i % 7 == 0 || Convert.ToString(i).Contains("7")) 
                        {
                            Console.WriteLine("---7---");
                        }
                       Console.ReadKey();
                    }  
                }
                else if (auswahl == 3)
                {
                    Console.WriteLine("Temperatur eingeben:");
                    int zahl = Convert.ToInt32(Console.ReadLine());
                    double  z = (zahl - 32) / (1.8);
                    double x = (zahl * (1.8) + 32);
                    Console.WriteLine(zahl+"°C entsprechend " +z+"°F");
                    Console.WriteLine(zahl + "°F entsprechend " + x + "°C");


                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte 1, 2 oder 3 wählen ");
                }
                Console.WriteLine("Andere Nummer wählen?");
                nochmal = Console.ReadLine();
                 
            } while ( nochmal == "j" || nochmal == "J");
           


        }
        
    }
}
