using System.Text;

var text = "ёбанный в рот того казино блять";

Console.WriteLine("Было: " + text);

text = Translate(text);

Console.WriteLine("Стало: " + text);

string Translate(string text)
{
    var textListSymbol = text.ToCharArray();

    var textBuilder = new StringBuilder();

    foreach (var item in textListSymbol)
    {
        var convertSymbol = Convert(item.ToString());
        textBuilder.Append(convertSymbol);
    }

    return textBuilder.ToString();
}

string? Convert(string symbol)
{
    var keyValueLanguage = new Dictionary<string, string>()
    {
        { "а", "a" },
        { "б", "b" },
        { "в", "v" },
        { "г", "g" },
        { "д", "d" },
        { "е", "e" },
        { "ё", "yo" },
        { "ж", "zh" },
        { "з", "z" },
        { "и", "i" },
        { "й", "i" },
        { "к", "k" },
        { "л", "l" },
        { "м", "m" },
        { "н", "n" },
        { "о", "o" },
        { "п", "p" },
        { "р", "r" },
        { "с", "s" },
        { "т", "t" },
        { "у", "u" },
        { "ф", "f" },
        { "х", "h" },
        { "ц", "ts" },
        { "ч", "ch" },
        { "ш", "sh" },
        { "щ", "shch" },
        { "ъ", "" },
        { "ы", "y" },
        { "ь", "" },
        { "э", "e" },
        { "ю", "yu" },
        { "я", "ya" }
    };

    keyValueLanguage.TryGetValue(symbol, out var convertValue);

    if (convertValue == null)
    {
        convertValue =
            keyValueLanguage.FirstOrDefault(x => x.Key.Equals(symbol, StringComparison.CurrentCultureIgnoreCase))
                .Value ?? symbol;
    }

    return convertValue;
}