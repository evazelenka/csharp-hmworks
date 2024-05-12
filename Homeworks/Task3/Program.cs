void maxNum(int x)
{
    if(x > 9 && x < 100)
    {
        if((x / 10) > (x % 10))
        {
            Console.WriteLine($"{x / 10}");
        }
        if((x / 10) < (x % 10))
        {
            Console.WriteLine($"{x % 10}");
        }
        if((x / 10) == (x % 10))
        {
            Console.WriteLine("equal");
        }
    }else
    {
        Console.WriteLine($"{x} is not allowed");
    }
}
Console.WriteLine("input number [10, 99]");
int num = Convert.ToInt32(Console.ReadLine());
maxNum(num);
