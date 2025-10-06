using ClassLib;
Point[] points = new Point[4];
Figure figure = new Figure(points);
bool exit = false;
bool isTrapezoid = false;

void enterPoints(Point[] points)
{
    Console.WriteLine("Введите точки трапеции по часовой стрелке: ");
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        points[i] = new Point(x, y);
    }
}

void checkPointBelongsTrapezoid()
{
    Console.WriteLine("Введите x: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите y: ");
    double y = Convert.ToDouble(Console.ReadLine());
    Point point = new Point(x, y);
    if (figure.isPointOnBorder(points, point)) 
        Console.WriteLine("Точка находится на границе трапеции");
    else if (figure.isPointInside(points, point)) 
        Console.WriteLine("Точка принадлежит трапеции");
    else 
        Console.WriteLine("Точка не принадлежит трапеции");
}

while (!exit)
{
    Console.WriteLine("----------------------------------------------------------------------------");
    Console.WriteLine("Выберите действие: \n 1 - Ввод точек трапеции \n 2 - Вычисление периметра трапеции \n 3 - Вычисление площади трапеции \n 4 - Проверка принадлежности точки трапеции \n 5 - Выход");
    Console.WriteLine("----------------------------------------------------------------------------");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            enterPoints(points);
            isTrapezoid = figure.isTrapezoid(points);
            if (!isTrapezoid) { 
                Console.WriteLine("Введенная фигура не является трапецией, попробуйте снова."); 
                break; 
            }
            break;
        case 2:
            if (!isTrapezoid) { 
                Console.WriteLine("Введенная фигура не является трапецией, попробуйте снова."); 
                break; 
            }
            Console.WriteLine("Периметр: " + Figure.getPerimeter(points));
            break;
        case 3:
            if (!isTrapezoid) { 
                Console.WriteLine("Введенная фигура не является трапецией, попробуйте снова."); 
                break; 
            }
            Console.WriteLine("Площадь: " + Figure.getArea(points));
            break;
        case 4:
            if (!isTrapezoid) { 
                Console.WriteLine("Введенная фигура не является трапецией, попробуйте снова."); 
                break; 
            }
            checkPointBelongsTrapezoid();
            break;
        case 5:
            exit = true;
            break;
        default:
            Console.WriteLine("Неверный выбор, попробуйте снова.");
            break;
    }
}