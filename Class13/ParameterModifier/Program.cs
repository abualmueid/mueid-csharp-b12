// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// double avg = CalculateAvg(new double[] {2, 3, 4, 5, 6});
double avg = CalculateAvg(2, 3, 4, 5, 6);

double CalculateAvg(params double[] numbers)
{
    double sum = 0;
    foreach (double number in numbers)
        sum += number;
    
    return sum/numbers.Length;
}

void UpdateValue1(in double value)
{
    // value = 5; // you cannot assign values here. readonly
}

void UpdateValue2(out double value)
{
    value = 5; // you can assign/modifies values
}

void UpdateValue3(ref double value)
{
    value = 5;
    value++;
}

double x = 3;
UpdateValue3(ref x);
Console.WriteLine(x);