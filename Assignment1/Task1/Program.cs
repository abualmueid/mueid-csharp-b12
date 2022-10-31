// Taking size of the array

int r, c;

Console.Write("Enter no of rows: ");
r = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter no of columns: ");
c = Convert.ToInt32(Console.ReadLine());

// Taking input of the array elements

int[,] a = new int[r, c];
Console.WriteLine("\nEnter elements of the array: ");
for (int i = 0; i < r; i++)
{
    string row = Console.ReadLine();
    string[] strings = row.Split(' ');

    for (int j = 0; j < c; j++)
        a[i, j] = Convert.ToInt32(strings[j]);
}

// Displaying 2D integer array

Console.WriteLine("\nThe 2D Array is: ");
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
        Console.Write(Convert.ToString(a[i, j]) + ' ');

    Console.WriteLine();
}
Console.WriteLine();

// Displaying row-wise sum

int MaxSum = 0;
for (int i = 0; i < r; i++)
{
    Console.Write("Sum of row " + (i + 1) + " is: ");
    int sum = 0;
    for (int j = 0; j < c; j++)
        sum += a[i, j];

    Console.WriteLine(sum);

    MaxValue(sum);
}
Console.WriteLine();

// Displaying column-wise sum

for (int i = 0; i < c; i++)
{
    Console.Write("Sum of column " + (i + 1) + " is: ");
    int sum = 0;
    for (int j = 0; j < r; j++)
        sum += a[j, i];

    Console.WriteLine(sum);

    MaxValue(sum);
}
Console.WriteLine();

// Displaying diagonal-wise sum

// Left Diagonal

Console.Write("Sum of left-diagonal is: ");
int leftsum = 0;
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        if (i == j)
            leftsum += a[i, j];
    }
}
Console.WriteLine(leftsum);
MaxValue(leftsum);

// Right Diagonal

Console.Write("Sum of right-diagonal is: ");
int rightsum = 0;
for (int i = 0; i < r; i++)
{
    for (int j = i; j < i + 1; j++)
        rightsum += a[i, c - 1 - i];
}
Console.WriteLine(rightsum);
MaxValue(rightsum);

// Calculating Maximum sum value 

void MaxValue(int val)
{
    if (val > MaxSum)
        MaxSum = val;
}

Console.WriteLine("\nMaximum sum value is: " + MaxSum);