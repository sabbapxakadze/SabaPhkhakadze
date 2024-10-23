// ა)

int a = 5;
int b = 7;
Console.WriteLine($"a={a} ... b={b}");
int c;

c = a;
a = b;
b = c;

Console.WriteLine($"a={a} ... b={b}");




Console.WriteLine("___________________________________________");




// ბ)

int d = 5;
int e = 10;
Console.WriteLine($"d={d} ... e={e}");


d = d + e;
e = d - e;
d = d - e;

Console.WriteLine($"d={d} ... e={e}");