using ClassLibrary;

Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();

Parser parser = new Parser();
Console.WriteLine(parser.Parse(str));