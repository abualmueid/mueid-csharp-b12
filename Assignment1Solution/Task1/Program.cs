Console.WriteLine("Enter Size of rows:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Size of columns:");
int cols = int.Parse(Console.ReadLine());

int[,] array = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    string[] nums = Console.ReadLine().Split(' ');
    for(int j= 0; j < cols && j < nums.Length; j++)
    {
        array[i, j] = int.Parse(nums[j]);
    }
}

int max = int.MinValue;
// row sum
for(int i = 0; i < rows; i++)
{
    int sum = 0;
    for(int j = 0; j < cols; j++)
    {
        sum += array[i, j];
    }
    if (sum > max)
        max = sum;
}

// column sum
for (int i = 0; i < cols; i++)
{
    int sum = 0;
    for (int j = 0; j < rows; j++)
    {
        sum += array[j, i];
    }
    if (sum > max)
        max = sum;
}

// diagonal sum
if (rows == cols)
{
    int diag1Sum = 0;
    int diag2Sum = 0;
    for (int i = 0; i < rows; i++)
    {
        diag1Sum += array[i, i];
        diag2Sum += array[i, rows - i - 1];
    }

    if (diag1Sum > max)
        max = diag1Sum;

    if (diag2Sum > max)
        max = diag2Sum;
}

Console.WriteLine($"Max value is: {max}");


