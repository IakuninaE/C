//Функция, проверяющая является ли слово палиндромом.

static string Palindrom(string phrase)
{
    var n = phrase.Length;

    if (n == 0)
        return "Некорректный ввод: строка не содержит текст.";

    var i = 0;
    while ((i < n) && !Char.IsLetter(phrase[i]) && !Char.IsNumber(phrase[i]))
        i++;

    if (i == n)
        return "Некорректный ввод: строка не содержит текст.";

    var k = n - 1;
    while (!Char.IsLetter(phrase[k]) && !Char.IsNumber(phrase[k]))
        k--;

    if ((k + 1 - i) < 3)
        return "Некорректный ввод: слишком короткий текст.";

    phrase = phrase.ToLower();
    List<char> letters = new List<char>();

    for (var j = i; j < k + 1; j++)
    {
        if (Char.IsNumber(phrase[j]))
            return "Некорректный ввод: строка содержит цифры.";

        if (Char.IsLetter(phrase[j]))
        {
            letters.Add(phrase[j]);
        }
    }

    var l = letters.Count;
    i = 0;
    while (i < (l / 2))
    {
        if (letters[i] != letters[l - 1 - i])
            return "Введённый текст не является палиндромом";
        i++;
    }
    return "Введённый текст является палиндромом";
}

Console.Write("Введите текст: ");
var phrase = Console.ReadLine();
var answer = Palindrom(phrase);
Console.WriteLine(answer);
while ((answer != "Введённый текст не является палиндромом") & (answer != "Введённый текст является палиндромом"))
{
    Console.WriteLine();
    Console.Write("Введите текст: ");
    phrase = Console.ReadLine();
    answer = Palindrom(phrase);
    Console.WriteLine(answer);
}











//if (Char.IsWhiteSpace(word[j]))
//    return "Некорректный ввод: строка содержит пробел.";
//if (Char.IsNumber(word[j]))
//    return "Некорректный ввод: строка содержит цифры.";

//if (!Char.IsLetter(word[j]) & !Char.IsWhiteSpace(word[j]))
//    return "Некорректный ввод: строка содержит недопустимые символы.";
