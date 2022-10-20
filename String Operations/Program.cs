char c = 'l';
int x = (int)c;
Console.WriteLine(x);

char y = (char)x;
Console.WriteLine(y);

string name = "Abu Al Mueid";
name = name.Replace("A", "B");
Console.WriteLine(name);

int pos = name.IndexOf('M');
Console.WriteLine(pos);

Console.WriteLine(char.IsPunctuation('e'));
