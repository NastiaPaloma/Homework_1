Console.WriteLine("Pleas, input the first integer number!");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pleas, input the second integer number!");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("Первое число является max!");
}
else
{
    Console.WriteLine("Второе число является max!");
}

if (n2 > n1)
{
    Console.WriteLine("Первое число является min!");
}
else
{
    Console.WriteLine("Второе число является min!");
}