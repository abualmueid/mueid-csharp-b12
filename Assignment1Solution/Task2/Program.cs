// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter how many numbers you want to input:");
int size = int.Parse(Console.ReadLine());

int firstMax = int.MinValue;
int secondMax = int.MinValue;
int thirdMax = int.MinValue;

for (int i = 0; i < size; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num > firstMax)
    {
        thirdMax = secondMax;
        secondMax = firstMax;
        firstMax = num;
    }
    else if (num > secondMax)
    {
        thirdMax = secondMax;
        secondMax = num;
    }
    else if (num > thirdMax)
        thirdMax = num;
}

Console.WriteLine(thirdMax);
