// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string CharToString(char[,] chars)
{
    string str = "";
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for(int j = 0; j < chars.GetLength(1); j++)
        {
            str+= chars[i,j];
        }
    }
    return str;
}

char[,] chars = {
    {'a', 'b', 'c', 'd'},
    {'f', 'g', 'h', 'i'}
};

Console.WriteLine(CharToString(chars));


// Задача 2: Задайте строку, содержащую латинские буквы 
// в обоих регистрах. Сформируйте строку, в которой все 
// заглавные буквы заменены на строчные. 



// Входная строка со смешанными буквами обоих регистров
string input = "aBcD1ef!-";
// Преобразование всех заглавных букв в строчные
string result = input.ToLower();
// Вывод результата
Console.WriteLine(result);


void Main(string[] args)
{
// Входная строка для проверки
string input = "шалаш";
// Вызов метода для проверки, является ли строка палиндромом
bool isPalindrome = IsPalindrome(input);
// Вывод результата
Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
// Метод для проверки, является ли строка палиндромом
public static bool IsPalindrome(string str)
{
// Нормализация строки путем удаления не буквенно-цифровых
символов и приведения к нижнему регистру
string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// Сравнение строки с ее перевернутым вариантом
return normalized.SequenceEqual(normalized.Reverse());
}

