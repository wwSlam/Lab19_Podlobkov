

// int CountCharacter(string text, char target)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (symbol == target)
//         {
//             count++;
//         }
//     }

//     return count;
// }



// Console.WriteLine(CountCharacter("мама", 'м'));
// Console.WriteLine(CountCharacter("Код 2026", ' '));
// Console.WriteLine(CountCharacter("", 'а'));


// int CountCharacter(string text, char target)
// {
//     int count = 0;

//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             count++;
//         }
//     }

//     return count;
// }

// Console.WriteLine(CountCharacter("мама", 'м'));
// Console.WriteLine(CountCharacter("", 'м'));



// int CountDigits(string text)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count++;
//         }
//     }

//     return count;
// }
// Console.WriteLine(CountDigits("Код 2026!"));

// int CountLetters(string text)
// {
//     int count = 0;
//     foreach (char symbol in text)
//     {
//         if (char.IsLetter(symbol))
//         {
//             count++;
//         }
//     }
//     return count;
// }


// Console.WriteLine(CountLetters("Код 2026!"));


// int CountDigits(string text)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count ++;
//         }
//     }

//     return count;
// }


// Console.WriteLine(CountDigits("A2B3"));


// int FindCharacterIndex(string text, char target)
// {
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             return i;
//         }
//     }
//     return -1;
// }

// Console.WriteLine(FindCharacterIndex("banana", 'a'));
// Console.WriteLine(FindCharacterIndex("banana", 'b'));
// Console.WriteLine(FindCharacterIndex("banana", 'z'));
// Console.WriteLine(FindCharacterIndex("", 'a'));


// int FindCharacterIndex(string text, char target)
// {
//     int index = -1;

//     for (int i = 0; i > text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             index = i;
//         }
//     }

//     return index;
// }

// Console.WriteLine(FindCharacterIndex("banana", 'a'));


// string sample = "  Привет, C#!  ";

// string trimmed = sample.Trim();
// string upper = sample.ToUpper();
// string lower = sample.ToLower();
// string replaced = sample.Replace(' ', '_');

// Console.WriteLine($"Исходная: [{sample}]");
// Console.WriteLine($"Без пробелов по краям: [{trimmed}]");
// Console.WriteLine($"Верхний регистр: [{upper}]");
// Console.WriteLine($"Нижний регистр: [{lower}]");
// Console.WriteLine($"Замена пробелов: [{replaced}]");


// string sample = "  кот  ";
// string trimmed = sample.Trim();
// Console.WriteLine($"[{trimmed}]");



// int CountWords(string text)
// {
//     string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     return words.Length;
// }


// Console.WriteLine(CountWords("Я изучаю C#"));
// Console.WriteLine(CountWords("  кот  дом  "));
// Console.WriteLine(CountWords(""));
// Console.WriteLine(CountWords("   "));


// int CountWords(string text)
// {
//     string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     return words.Length;
// }

// Console.WriteLine(CountWords("  кот  дом  "));


Console.Write("Введите строку: ");
string text = Console.ReadLine() ?? "";

int count = 0;
foreach (char symbol in text)
{
    if (char.IsLetter(symbol))
    {
        count++;
    }
}

int total = 0;
foreach (char symb in text)
{
    if (char.IsDigit(symb))
    {
        total++;
    }
}
string saP = text.ToUpper();
string sap = text.Replace(' ', '_');
string bap = text.Trim();

int CountWords(string text)
{
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}

Console.WriteLine($"Исходная строка: [{text}]");
Console.WriteLine($"Длина: {text.Length}");
Console.WriteLine($"Букв: {count}");
Console.WriteLine($"Цифр: {total} ");
Console.WriteLine($"Пробелов: {}");
Console.WriteLine($"Слов: {CountWords(text)}");
Console.WriteLine($"Без пробелов по краям: [{bap}]");
Console.WriteLine($"Верхний регистр: [{saP}]");
Console.WriteLine($"Замена пробелов: [{sap}]");