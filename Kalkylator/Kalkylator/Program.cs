using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator
{
    internal class Program
    {
        static void ÄndraFärgerna()
        {
            // Bestäm färgerna
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            // Töm och applicera nya bakgrundsfärgen
            Console.Clear();
        }
        
        static void ShowHandArt()
        {
            Console.WriteLine(@"
      _
   _ | |
 _ | | |
| | | |
| | | | __
| | | |/  \
|       /\ \
|      /  \/
|      \  /\
|       \/ /
 \        /
  |     /
  |    |");
        }

        static void ShowCalculatorArt()
        {
            Console.WriteLine(@"
 _____________________
|  _________________  |
| | JO           0. | |
| |_________________| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|
Grafik av: Jeremy J. Olson");
        }

        static void Plus(double nummer1, double nummer2)
        {
            double resultat = nummer1 + nummer2;
            Console.WriteLine($"{nummer1} + {nummer2} = {resultat}");
        }

        static void Minus(double nummer1, double nummer2)
        {
            double resultat = nummer1 - nummer2;
            Console.WriteLine($"{nummer1} - {nummer2} = {resultat}");
        }

        static void Gånger(double nummer1, double nummer2)
        {
            double resultat = nummer1 * nummer2;
            Console.WriteLine($"{nummer1} * {nummer2} = {resultat}");
        }

        static void DelatMed(double nummer1, double nummer2)
        {
            double resultat = nummer1 / nummer2;
            Console.WriteLine($"{nummer1} / {nummer2} = {resultat}");
        }


        static void Main(string[] args)
        {
            /// BOOL VARIABLER ///
            bool loopKörs = true;       // Används av Do-while loopen
            bool skriverTal = true;     // Används av andra Do-while loopen
            bool skriverTalIgen = true; 
            bool valAvRäkneSätt = true; // Används av första While-loopen
            bool räknaMerLoop = true;   // Används av andra While-loopen

            // Deklarerar tal1 och tal2 här så att de finns tillgängliga i try and catch blocken
            double tal1 = 0;
            double tal2 = 0;

            // Ändrar färgerna
            ÄndraFärgerna();

            // Titel
            Console.WriteLine("Den enkla kalkylatorn");
            Console.WriteLine("=====================");
            Console.WriteLine("Av: Marcus Malinda Lindmark © 2024\n");

            // Visar grafiken
            ShowCalculatorArt();

            Console.WriteLine("\nTryck på valfri tangent.");
            Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            // Töm och applicera nya bakgrundsfärgen
            Console.Clear();
            


            // Introtext
            Console.WriteLine("\nVälkommen till den enkla kalkylatorn!");
            Console.WriteLine("Den fungerar ungefär som en miniräknare.");

            // Körs så länge som användaren vill fortsätta räkna
            do
            {
                
                // Användaren skriver in första talet
                do
                {
                    try
                    { 
                        Console.Write("\nSkriv in det första talet: ");
                        tal1 = double.Parse(Console.ReadLine());
                        skriverTal = false;
                    }

                    catch
                    {
                        Console.WriteLine("Du får bara skriva siffror! Försök igen.");
                    }
                } while (skriverTal == true);


                // Användaren skriver in andra talet
                do
                {
                    try
                    { 
                        Console.Write("\nSkriv in det andra talet: ");
                        tal2 = double.Parse(Console.ReadLine());
                        skriverTalIgen = false;
                    }

                    catch
                    {
                        Console.WriteLine("Du får bara skriva siffror! Försök igen.");
                    }
                } while (skriverTalIgen == true);


                // Användaren väljer räknesätt
                while (valAvRäkneSätt == true)
                {
                    Console.Write("\nVälj ett räknesätt(plus, minus, gånger, delat med) ");
                    string räknesätt = Console.ReadLine().ToLower();

                    // Anropar olika metoder beroende på vilket räknesätt som valts
                    if (räknesätt == "plus")
                    {
                        Plus(tal1, tal2);
                        // Sätter till true så att räknaMer-loopen garanterat körs
                        räknaMerLoop = true;    
                        
                        // Avbryter loopen eftersom användaren gjort ett val.
                        valAvRäkneSätt = false;
                    }
                    else if (räknesätt == "minus")
                    {
                        Minus(tal1, tal2);
                        // Sätter till true så att räknaMer-loopen garanterat körs
                        räknaMerLoop = true;

                        // Avbryter loopen eftersom användaren gjort ett val.
                        valAvRäkneSätt = false;
                    }
                    else if (räknesätt == "gånger")
                    {
                        Gånger(tal1, tal2);

                        // Sätter till true så att räknaMer-loopen garanterat körs
                        räknaMerLoop = true;

                        // Avbryter loopen eftersom användaren gjort ett val.
                        valAvRäkneSätt = false;
                    }
                    else if (räknesätt == "delat med")
                    {
                        DelatMed(tal1, tal2);

                        // Sätter till true så att räknaMer-loopen garanterat körs
                        räknaMerLoop = true;

                        // Avbryter loopen eftersom användaren gjort ett val.
                        valAvRäkneSätt = false;
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                    }
                }

                while (räknaMerLoop == true)
                { 
                    Console.Write("\nVill du räkna mera (ja/nej)? ");
                    string räknaMera = Console.ReadLine().ToLower();
                    if (räknaMera == "ja")
                    {
                        Console.WriteLine("\nDu vill räkna mer. Då kör vi! :)\n");
                        Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                        Console.ReadLine();
                        Console.Clear();
                        

                        // Eftersom användaren vill räkna mer återställs looparna
                        skriverTal = true;    
                        skriverTalIgen = true;
                        valAvRäkneSätt = true;
                        räknaMerLoop = false;   // Avslutar while-loopen
                    }
                    else if (räknaMera == "nej")
                    {
                        Console.WriteLine("\nDu vill inte räkna mer. Då ses vi nästa gång!");
                        Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                        Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        räknaMerLoop = false;   // Avlutar while-loopen
                        loopKörs = false;       // Avslutar do-while loopen
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt val. Försök igen!");
                    }
                }

            } while (loopKörs == true);


            // Avslutande text till användaren
            ShowHandArt();
            Console.WriteLine("\nTack för att du använde kalkylatorn. :)");
            Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
            Console.ReadLine();
        }
    }
}
