using OOP2;

class Program
{
    public static void Main(string[] args)
    {
        ////////////////// bottle //////////////////
        
        WaterBottle bottle = new WaterBottle();
        bottle.Capacity = 100;
        //bottle.waterAmount = 300;
        bottle.WaterAmount = 300;
       
        //bottle.AddWater(200);
        //bottle.IsOpen = true;

        //Console.WriteLine(bottle.GetColor());
        //Console.WriteLine(bottle.Color);
        Console.WriteLine(bottle.waterAmount);
        Console.WriteLine(bottle.WaterAmount); // get{} is being called here
        Console.WriteLine(bottle.Capacity);
        //Console.WriteLine(bottle.IsOpen);
        //Console.WriteLine(bottle.isOpen);
        

        ////////////////// bottle2 //////////////////

        
        WaterBottle bottle2 = new WaterBottle("blue", 300);
        //bottle2.waterAmount = 800;
        //bottle2.WaterAmount = 200;
        //bottle2.AddWater(200);
        //bottle2.IsOpen = false;

        //Console.WriteLine(bottle2.GetColor());
        //Console.WriteLine(bottle2.waterAmount);
        //Console.WriteLine(bottle2.WaterAmount);
        //Console.WriteLine(bottle2.IsOpen);
        
        




    }


}