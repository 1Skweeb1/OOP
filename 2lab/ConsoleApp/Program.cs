using ClassLib.Second;
Console.WriteLine("Введите первый вектор: ");
var firstVector = EnterVector();
Console.WriteLine("Введите второй вектор: ");
var secondVector = EnterVector();

Console.WriteLine($"Векторная разность: { firstVector - secondVector }");
Console.WriteLine($"Векторная сумма: { firstVector + secondVector }");
Console.WriteLine($"Векторное произведение: { firstVector * secondVector }");

Vector EnterVector()
{
    Console.Write("X: ");
    double x = double.Parse(Console.ReadLine()!);
    Console.Write("Y: ");
    double y = double.Parse(Console.ReadLine()!);
    Console.Write("Z: ");
    double z = double.Parse(Console.ReadLine()!);
    return new Vector(x, y, z);
}