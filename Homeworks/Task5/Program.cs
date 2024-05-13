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



// class Program
// {
// static void Main()
// {
// while (true) // Бесконечный цикл
// {
// Console.Write("Введите число или 'q' для выхода: ");
// string input = Console.ReadLine(); // Чтение строки ввода пользователя
// if (input == "q") // Проверка на ввод 'q' для выхода
// {
// break;
// }
// int number;
// if (int.TryParse(input, out number)) // Проверка, является ли ввод числом
// {
// int sum = 0;
// while (number > 0) // Вычисление суммы цифр числа
// {
// sum += number % 10; // Добавление последней цифры к сумме
// number /= 10; // Удаление последней цифры из числа
// }
// if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
// {
// Console.WriteLine("[STOP]");
// break;
// }
// }
// else // Если ввод не является числом и не 'q', повторить запрос
// {
// Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число
// или 'q'.");
// }
// }
// }
// }
