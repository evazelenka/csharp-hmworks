// string CharsToString(char[] chars)
// {
//     string str = "";
//     for(int i = 0; i < chars.Length; i++)
//     {
//         str+= chars[i];
//     }
//     return str;
// }

// char[] chars = {'a', 'b', 'c', 'd'};
// Console.WriteLine(CharsToString(chars));

// На основе символов строки (тип string) сформировать массив 
// символов (тип char[]). Вывести массив на экран.

// char[] StringToChars(string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// void ShowChars(char[] chars)
// {
//     Console.Write("[");
//     for (int i = 0; i < chars.Length - 1; i++)
//     {
//         Console.Write($"'{chars[i]}', ");
//     }
//     Console.Write($"'{chars[chars.Length - 1]}']");
// }
// string str = "Hello!";
// ShowChars(StringToChars(str));



char[] StringToChars(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

int CountLetters(char[] chars)
{
    int cntr = 0;
    char[] letters = {'a', 'e', 'i', 'o', 'u', 'y'};
    for(int i = 0; i < chars.Length; i++)
    {
        for(int j = 0; j < letters.Length; j++)
        {
            if (chars[i] == letters[j])
            {
                cntr++;
            }
        }
    }
    return cntr;
}

Console.WriteLine("Input word");
string str = Console.ReadLine();
char[] chars = StringToChars(str);
Console.WriteLine(CountLetters(chars));