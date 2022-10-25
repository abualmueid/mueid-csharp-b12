namespace OOP
{
    internal class WaterBottle
    {
        private string color;
        internal double waterAmount;
        private double capacity;
        internal bool isOpen;

        // Constructor Overloading
        internal WaterBottle() : this("red", 100)
        {
            Console.WriteLine("Constructor without parameter");
        }

        // Constructor Overloading

        internal WaterBottle(string color, double capacity)
        {
            this.color = color;
            //this.waterAmount = 10;
            if (capacity < 100)
                capacity = 100;
            else
                this.capacity = capacity;

            Console.WriteLine("Constructor with parameter");
        }

        internal void AddWater(double amount)
        {
            waterAmount += amount;
        }

        // Method Overloading
        internal void AddWater(int amount)
        {
            waterAmount += amount;
        }

        internal void AddWater(double amount, string str)
        {
            waterAmount += amount;
        }

        internal void AddWater(string str, double amount)
        {
            waterAmount += amount;
        }

        // Get Method
        internal string GetColor()
        {
            return color;
        }

        // Property
        internal string Color
        {
            get
            {
                return color;
            }
        }

        internal double WaterAmount
        {
            get
            {
                if (waterAmount < 0)
                    return 0;
                else if (waterAmount > capacity)
                    return capacity;
                else
                    return waterAmount;
            }

            set
            {
                //if(value >= 0 && value <= capacity)
                    waterAmount = value;
            }
        }

        internal double Capacity 
        {
            get { return capacity; } 
            set { capacity = value; } 
        }

        // Auto Property
        internal bool IsOpen { get; set; }

        // Destructor

        ~WaterBottle()
        {
            color = "";
            waterAmount = 0;
        }

    
    }
}

