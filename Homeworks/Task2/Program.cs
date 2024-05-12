void coordinatesOfPoint(int a, int b) 
{
    if (a != 0 && b != 0)
    {
        if(a > 0 && b > 0)
        {
            Console.WriteLine(1);
        }
        if(a < 0 && b > 0)
        {
            Console.WriteLine(2);
        }if(a < 0 && b < 0)
        {
            Console.WriteLine(3);
        }if(a > 0 && b < 0)
        {
            Console.WriteLine(4);
        }
    }else
    {
        Console.WriteLine("wrong coordinates");
    }
}

Console.WriteLine("Input x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y");
int y = Convert.ToInt32(Console.ReadLine());
coordinatesOfPoint(x, y);

