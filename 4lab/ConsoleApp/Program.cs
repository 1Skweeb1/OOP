Console.WriteLine("Введите строку из нескольких слов: ");
string input = Console.ReadLine()!;
string[] words = input.Split(' ');


Console.WriteLine("Повторяющиеся слова в строке: ");
foreach (var word in words)
{
    if (word[0] == word[word.Length - 1])
    {
        Console.WriteLine(word);
    }
}
// using System.Text;
// using ClassLibrary;

// Console.WriteLine("Введите арифметическое выражение: ");
// string input = Console.ReadLine()!;
// List<Unit> units = new List<Unit>();

// for(int i = 0; i < input.Length; i++)
// {
//     Unit unit = new Unit();
//     var sb = new StringBuilder("выражения: ");
//     if (input[i] == '+')
//     {
//         unit.EnterUnit('+', System.Convert.ToString(input[i - 1]), System.Convert.ToString(input[i + 1]));
//         units.Add(unit);
//     }
//     if (input[i] == '-')
//     {
//         unit.EnterUnit('-', System.Convert.ToString(input[i - 1]), System.Convert.ToString(input[i + 1]));
//         units.Add(unit);
//     }
//     if(input[i] == '*')
//     {
//         for(int j = i; j < input.Length; j++)
//         {
            
//         }
//         // unit.EnterUnit('*', input.Substring(0, i), input[i + 1]);
//         units.Add(unit);
//     }
//     if (input[i] == '/')
//     {
//         // unit.EnterUnit('/', input[i - 1], input[i + 1]);
//         units.Add(unit);
//     }
// }

