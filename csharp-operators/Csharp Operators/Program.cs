// Increment

int p = 10;

int a = ++p;
int b = p++;

Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);

// Math Operator

float x = 3.08f;
double y = 2.56d;
decimal z = 3.08m;

// Bitwise complement operator 

uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
uint b11 = ~t;
Console.WriteLine(Convert.ToString(b11, toBase: 2));

// Logical Operators

uint a1 = 0b_1111_1000;
uint b1 = 0b_1001_1101;
uint c1 = a1 & b1;
Console.WriteLine(Convert.ToString(c1, toBase: 2));
// Output:
// 10011000

uint p1 = 0b_1111_1000;
uint q1 = 0b_1001_1101;
uint r = p1 | q1;
Console.WriteLine(Convert.ToString(r, toBase: 2));
// Output:
// 11111101

uint w = 0b_1111_1000;
uint v = 0b_0001_1100;
uint z1 = w ^ v; // xor
Console.WriteLine(Convert.ToString(z1, toBase: 2));
// Output:
// 11100100



