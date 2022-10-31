using System.Numerics;

// Taking no of integers from the user

Console.Write("How many numbers you want to input?: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nEnter " + n + " integer numbers one by one (each one in a line).");

// Taking inputs from the user and finding the third largest number 

int first, second, third;
first = second = third = int.MinValue;
for (int i = 0; i < n; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());

    if (i == 0)
        first = number;

    else if (number > first)
    {
        third = second;
        second = first;
        first = number;
    }

    else if (number > second)
    {
        third = second;
        second = number;
    }

    else if (number > third)
        third = number;
}

Console.WriteLine("\nThe 3rd largest number is: " + third);