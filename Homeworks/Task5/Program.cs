// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void Endless (int y)
{
    int cnt = 1;
    int sum = 0;
    while (cnt % 2 != 0) 
    {
        if(y > 9)
    {
         while(y > 0)
        {
            sum = sum + y % 10;
            y = y / 10;
        }
        cnt = sum;
    } else
    {
        cnt = y;
    }
    if (cnt % 2 != 0)
    {
        Console.WriteLine("Input Number");
        y = Convert.ToInt32(Console.ReadLine());
        cnt = 1;
        sum = 0;
    }
    }
}
Console.WriteLine("Input Number");
int x = Convert.ToInt32(Console.ReadLine());
Endless (x);
