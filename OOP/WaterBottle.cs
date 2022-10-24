namespace OOP
{
    internal class WaterBottle
    {
        internal double waterAmount;
        internal string color;

        internal WaterBottle(string color)
        {
            this.color = color;
        }

        internal void AddWater(double amount)
        {
            waterAmount += amount;
        }

        // Get Method
        internal string GetColor()
        {
            return color;
        }
    }
}