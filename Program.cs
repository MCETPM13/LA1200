using System;

namespace ZZ_Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            string Game = "ja";
            NewMethod(Game);
        }

        private static void NewMethod(string Game)
        {
            do
            {
                DateTime start = DateTime.Now;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                //Hier kann der Benutzer seinen Namen eingeben
                Console.WriteLine("Hallo, willkommen zum Ratespiel");
                Console.WriteLine();
                Console.WriteLine("Gib deinen Namen ein: ");
                string Name = Console.ReadLine();
                //Dieser Schritt zeigt an was das Programm macht
                Console.WriteLine($"Also, {Name} ich habe mir eine Zahl zwischen 1 und 100 Ausgedacht, versuche diese zu erraten.");
                //Zufallszahl generieren
                Random rnd = new Random();
                int Number = rnd.Next(1, 101);
                Console.WriteLine($"(Die generierte Zahl ist: {Number})");
                int Guesses = 1;
                int GNumber = Int32.Parse(Console.ReadLine());
                while (GNumber != Number)
                {
                    if (GNumber < Number)
                    {
                        Console.WriteLine("Die Zahl ist grösser");
                        GNumber = int.Parse(Console.ReadLine());
                    }
                    else if (GNumber > Number)
                    {
                        Console.WriteLine("Die Zahl ist kleiner");
                        GNumber = int.Parse(Console.ReadLine());
                    }

                    Guesses++;
                }
                DateTime finish = DateTime.Now;
                Console.WriteLine($"Ihre Zeit: {finish-start}");
                Console.WriteLine($"Glückwunsch {Name}! Sie haben die Zahl erraten!");
                Console.WriteLine($"Anzahl Versuche: {Guesses}");
                Console.WriteLine("Möchten Sie nochmal spielen?");
                Console.ReadLine();
            } while (Game == "ja");
        }
    }    
}

