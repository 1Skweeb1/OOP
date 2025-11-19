using ClassLibrary;

Console.WriteLine("Введите строку из нескольких слов: ");
string input = Console.ReadLine()!;
WordFinder wordFinder = new WordFinder();
Console.WriteLine("Слова, которые начинаются и заканчиваются одной и той же буквой: ");
Console.WriteLine(wordFinder.FindWords(input));

Console.WriteLine("Введите математическое выражение");
string mathInput = Console.ReadLine()!;
ExpressionHandler expressionHandler = new ExpressionHandler();
Console.WriteLine("Полученные простые выражения: ");
Console.WriteLine(expressionHandler.ConvertResult(expressionHandler.Parse(mathInput)));
