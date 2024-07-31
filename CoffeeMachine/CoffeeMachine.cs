using System;
using System.Threading;

namespace CoffeeMachine;

public enum CoffeeType { Black, Latte }
public enum CupSize { Small, Medium, Large }

public class CoffeeMachine
{
    public int CoffeeBeansLevel { get; private set; } = 100;
    public int WasteContainerLevel { get; private set; } = 0;
    public int WaterLevel { get; private set; } = 100;
    public int MilkContainerLevel { get; private set; } = 100;
    public bool NeedsDescaling { get; private set; } = false;
    public double WaterTemperature { get; private set; } = 90.0; // in Celsius
    public double MilkTemperature { get; private set; } = 20.0; // in Celsius

    public string BrewCoffee(CoffeeType coffeeType, CupSize cupSize)
    {

        if (CoffeeBeansLevel < 10 || WaterLevel < 10 || WasteContainerLevel > 80)
            return "Kann keinen Kaffee brühen: Überprüfen Sie die Füllstände.";

        GrindBeans();
        HeatWater();
        if (coffeeType == CoffeeType.Latte)
        {
            HeatMilk();
        }

        // Simulate brewing process
        CoffeeBeansLevel -= 10;
        WaterLevel -= 10;
        WasteContainerLevel += 10;

        return $"{coffeeType} in einer {cupSize} Tasse ist fertig!";
    }

    private void GrindBeans()
    {
        Console.WriteLine("Mahlen der Bohnen");
        ShowLoadingBar(300);
        Console.WriteLine();
    }

    private void HeatWater()
    {
        Console.WriteLine("Erhitzen des Wassers");
        ShowLoadingBar(300);
        WaterTemperature = 95.0;
        Console.WriteLine();
    }

    private void HeatMilk()
    {
        Console.WriteLine("Erhitzen der Milch");
        ShowLoadingBar(300);
        if (MilkContainerLevel < 10)
            throw new InvalidOperationException("Nicht genug Milch!");
        MilkTemperature = 60.0;
        MilkContainerLevel -= 10;
        Console.WriteLine();
    }

    private void ShowLoadingBar(int sleep)
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(sleep); // 300 ms * 10 = 3000 ms (3 Sekunden)
            Console.Write("=");
        }
        Console.WriteLine();
    }

    public void CheckDescaling()
    {
        NeedsDescaling = (WaterLevel < 10);
    }

    public string DispenseHotWater()
    {
        if (WaterLevel < 20)
            return "Nicht genug Wasser, um heißes Wasser auszugeben.";
        
        HeatWater();
        WaterLevel -= 20;
        return "Heißes Wasser ist bereit!";
    }

    public void SetWaterTemperature(double temperature)
    {
        if (temperature < 80.0 || temperature > 100.0)
            throw new ArgumentOutOfRangeException("Die Wassertemperatur muss zwischen 80 und 100 Grad Celsius liegen.");
        
        WaterTemperature = temperature;
        Console.WriteLine($"Die Wassertemperatur wurde auf {temperature} Grad Celsius eingestellt.");
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Kaffeebohnenstand: {CoffeeBeansLevel}%");
        Console.WriteLine($"Wasserstand: {WaterLevel}%");
        Console.WriteLine($"Milchstand: {MilkContainerLevel}%");
        Console.WriteLine($"Abfallbehälterstand: {WasteContainerLevel}%");
        Console.WriteLine($"Entkalkung erforderlich: {NeedsDescaling}");
    }
}