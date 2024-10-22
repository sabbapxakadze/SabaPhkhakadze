
int year = 8;

bool result = false;

if ((year % 4 == 0 && year%100!=0)|| year % 400 == 0) result = true;

Console.WriteLine(result);
