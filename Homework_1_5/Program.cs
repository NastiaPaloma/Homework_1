Console.WriteLine("Enter an integer number");
int number = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;
if (number > 99)
{
    k = number;
    while ( k >= 1000)
    {
        k /= 10;
        d = k % 10;
    }
    Console.WriteLine($"The third number from the left is {d}");
}
else
{
    Console.WriteLine($"The number has fewer than 3 digits, sorry.");
}
