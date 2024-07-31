using System;
namespace CoffeeMachine;

class Program
{
    static void Main(string[] args)
    {

        CoffeeMachine machine = new CoffeeMachine();

        while (true)
        {
            Console.WriteLine("Willkommen bei der Kaffeemaschine!");
            Console.WriteLine("1. Kaffee brühen");
            Console.WriteLine("2. Heißes Wasser ausgeben");
            Console.WriteLine("3. Wassertemperatur einstellen");
            Console.WriteLine("4. Maschinenstatus anzeigen");
            Console.WriteLine("5. Beenden");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BrewCoffee(machine);
                    break;
                case 2:
                    DispenseHotWater(machine);
                    break;
                case 3:
                    SetWaterTemperature(machine);
                    break;
                case 4:
                    machine.ShowStatus();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
    }

    static void BrewCoffee(CoffeeMachine machine)
    {
        Console.WriteLine("Wählen Sie Ihren Kaffee:");
        Console.WriteLine("1. Schwarz");
        Console.WriteLine("2. Milchkaffee");

        int coffeeChoice = int.Parse(Console.ReadLine());
        CoffeeType coffeeType = coffeeChoice == 1 ? CoffeeType.Black : CoffeeType.Latte;

        Console.WriteLine("Wählen Sie die Tassengröße:");
        Console.WriteLine("1. Klein");
        Console.WriteLine("2. Mittel");
        Console.WriteLine("3. Groß");

        int sizeChoice = int.Parse(Console.ReadLine());
        CupSize cupSize = sizeChoice switch
        {
            1 => CupSize.Small,
            2 => CupSize.Medium,
            3 => CupSize.Large,
            _ => CupSize.Medium
        };

        string result = machine.BrewCoffee(coffeeType, cupSize);
        Console.WriteLine(result);
    }

    static void DispenseHotWater(CoffeeMachine machine)
    {
        string result = machine.DispenseHotWater();
        Console.WriteLine(result);
    }

    static void SetWaterTemperature(CoffeeMachine machine)
    {
        Console.WriteLine("Geben Sie die gewünschte Wassertemperatur (80-100 Grad Celsius) ein:");
        double temperature = double.Parse(Console.ReadLine());

        try
        {
            machine.SetWaterTemperature(temperature);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}