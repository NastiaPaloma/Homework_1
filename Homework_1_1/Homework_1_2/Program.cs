Console.WriteLine("Please, input the first integer number!");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input the second integer number!");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input the third integer number!");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if (n1 > max) max = n1;
if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.Write("max=");
Console.WriteLine(max);
