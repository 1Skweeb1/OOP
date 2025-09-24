using ClassLib;
Point[] points = new Point[4];
Figure figure = new Figure(points);
bool exit = false;
bool isTrapezoid = false;


void enterPoints(Point[] points)
{
    Console.WriteLine("Enter points of trapezoid clockwise: ");
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Enter x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        points[i] = new Point(x, y);
    }
}

void checkPointBelongsTrapezoid()
{
    Console.WriteLine("Enter x: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter y: ");
    double y = Convert.ToDouble(Console.ReadLine());
    Point point = new Point(x, y);
    if (figure.isPointOnBorder(points, point)) Console.WriteLine("Point is on border of trapezoid");
    else if (figure.isPointInside(points, point)) Console.WriteLine("Point belongs to trapezoid");
    else Console.WriteLine("Point doesn't belong to trapezoid");
}

while (!exit)
{
    Console.WriteLine("----------------------------------------------------------------------------");
    Console.WriteLine("Enter your choice: \n 1 - Enter points of trapezoid \n 2 - solve perimeter of entered trapezoid \n 3 - solve area of entered trapezoid \n 4 - entering a point to check whether it belongs to a trapezoid \n 5 - exit");
    Console.WriteLine("----------------------------------------------------------------------------");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            enterPoints(points);
            isTrapezoid = figure.isTrapezoid(points);
            if (!isTrapezoid) { Console.WriteLine("Entered figure is not a trapezoid, try again."); break; }
            break;
        case 2:
            if (!isTrapezoid) { Console.WriteLine("Entered figure is not a trapezoid, try again."); break; }
            Console.WriteLine("Perimeter: " + Figure.getPerimeter(points));
            break;
        case 3:
            if (!isTrapezoid) { Console.WriteLine("Entered figure is not a trapezoid, try again."); break; }
            Console.WriteLine("Area: " + Figure.getArea(points));
            break;
        case 4:
            if (!isTrapezoid) { Console.WriteLine("Entered figure is not a trapezoid, try again."); break; }
            checkPointBelongsTrapezoid();
            break;
        case 5:
            exit = true;
            break;
        default:
            break;
    }
}


