using System.Text;

var keyValueLanguage = new Dictionary<char, string>()
{
    { 'а', "a" },
    { 'б', "b" },
    { 'в', "v" },
    { 'г', "g" },
    { 'д', "d" },
    { 'е', "e" },
    { 'ё', "yo" },
    { 'ж', "zh" },
    { 'з', "z" },
    { 'и', "i" },
    { 'й', "i" },
    { 'к', "k" },
    { 'л', "l" },
    { 'м', "m" },
    { 'н', "n" },
    { 'о', "o" },
    { 'п', "p" },
    { 'р', "r" },
    { 'с', "s" },
    { 'т', "t" },
    { 'у', "u" },
    { 'ф', "f" },
    { 'х', "h" },
    { 'ц', "ts" },
    { 'ч', "ch" },
    { 'ш', "sh" },
    { 'щ', "shch" },
    { 'ъ', "" },
    { 'ы', "y" },
    { 'ь', "" },
    { 'э', "e" },
    { 'ю', "yu" },
    { 'я', "ya" }
};

var text = "ёбанный в рот того казино щлюха";

Console.WriteLine("Было: " + text);

text = Translate(text);

Console.WriteLine("Стало: " + text);

string Translate(string text)
{
    var textBuilder = new StringBuilder();

    foreach (var item in text)
    {
        var convertSymbol = Convert(char.ToLower(item));
        textBuilder.Append(convertSymbol);
    }

    return textBuilder.ToString();
}

string Convert(char symbol)
{

    if (keyValueLanguage.TryGetValue(symbol, out var convertValue))
    {
        return convertValue;
    }

    return symbol.ToString();
}