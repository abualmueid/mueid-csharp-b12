using OOP;

class Program
{
    public static void Main(string[] args)
    {
        WaterBottle bottle = new WaterBottle("red");
        bottle.waterAmount = 300;
        bottle.AddWater(200);

        WaterBottle bottle2 = new WaterBottle("blue");
        bottle2.waterAmount = 800;
        bottle2.AddWater(200);

        Console.WriteLine(bottle.waterAmount);
        Console.WriteLine(bottle2.waterAmount);
        Console.WriteLine(bottle.GetColor());
        Console.WriteLine(bottle2.GetColor());
    }
}
