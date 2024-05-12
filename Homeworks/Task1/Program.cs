void multipleTo( int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"{num} is multiple to 7 and to 23.");
    } else
    {
        Console.WriteLine($"{num} is not multiple to 7 and to 23.");
    }
}

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
multipleTo(number);