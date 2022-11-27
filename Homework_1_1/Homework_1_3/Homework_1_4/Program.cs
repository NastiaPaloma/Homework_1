Console.WriteLine("Enter a positive integer!");
int num = Convert.ToInt32(Console.ReadLine());
int n = 0;

while (n <= num)  // Выводит все числа от 1 до введенного числа
{
    if (n%2 == 0) Console.Write( n + " " );
    n ++1;
}
