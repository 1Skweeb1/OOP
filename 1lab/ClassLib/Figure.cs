namespace ClassLib;

/// <summary>
/// Представляет геометрическую фигуру и предоставляет методы для работы с ней
/// </summary>
public class Figure
{
    Point[] points;
    
    /// <summary>
    /// Инициализирует новую фигуру с указанными точками
    /// </summary>
    /// <param name="points">Массив точек, определяющих фигуру</param>
    public Figure(Point[] points)
    {
        this.points = points;
    }

    /// <summary>
    /// Проверяет, является ли фигура трапецией
    /// </summary>
    /// <param name="points">Массив точек фигуры</param>
    /// <returns>True если фигура является трапецией, иначе False</returns>
    public bool isTrapezoid(Point[] points)
    {
        if (points.Length != 4) return false;
        if (points[0] == points[1] || points[1] == points[2] || points[2] == points[3] || points[3] == points[0]) return false;
        
        if (isSidesParallel(points[0], points[1], points[2], points[3])
        || isSidesParallel(points[1], points[2], points[3], points[0])
        || isSidesParallel(points[2], points[3], points[0], points[1])) return true;

        return false;
    }

    /// <summary>
    /// Проверяет параллельность двух сторон
    /// </summary>
    /// <param name="p1">Первая точка первой стороны</param>
    /// <param name="p2">Вторая точка первой стороны</param>
    /// <param name="p3">Первая точка второй стороны</param>
    /// <param name="p4">Вторая точка второй стороны</param>
    /// <returns>True если стороны параллельны</returns>
    private static bool isSidesParallel(Point p1, Point p2, Point p3, Point p4)
    {
        return (p1.x - p2.x) * (p3.y - p4.y) == (p1.y - p2.y) * (p3.x - p4.x);
    }

    /// <summary>
    /// Вычисляет длину отрезка между двумя точками
    /// </summary>
    /// <param name="p1">Первая точка</param>
    /// <param name="p2">Вторая точка</param>
    /// <returns>Длина отрезка</returns>
    public static double getSideLength(Point p1, Point p2)
    {
        return Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
    }

    /// <summary>
    /// Вычисляет периметр фигуры
    /// </summary>
    /// <param name="points">Массив точек фигуры</param>
    /// <returns>Периметр фигуры</returns>
    public static double getPerimeter(Point[] points)
    {
        return getSideLength(points[0], points[1]) + getSideLength(points[1], points[2]) + getSideLength(points[2], points[3]) + getSideLength(points[3], points[0]);
    }

    /// <summary>
    /// Вычисляет площадь фигуры (трапеции)
    /// </summary>
    /// <param name="points">Массив точек фигуры</param>
    /// <returns>Площадь фигуры</returns>
    public static double getArea(Point[] points)
    {
        if (isSidesParallel(points[0], points[1], points[2], points[3]))
        {
            return (getSideLength(points[0], points[1]) + getSideLength(points[2], points[3])) / 2 * getHeight(points[0], points[1], points[2], points[3]);
        }

        if (isSidesParallel(points[1], points[2], points[3], points[0]))
        {
            return (getSideLength(points[1], points[2]) + getSideLength(points[3], points[0])) / 2 * getHeight(points[1], points[2], points[3], points[0]);
        }

        return (getSideLength(points[2], points[3]) + getSideLength(points[0], points[1])) / 2 * getHeight(points[2], points[3], points[0], points[1]);
    }

    /// <summary>
    /// Вычисляет высоту трапеции
    /// </summary>
    /// <param name="A">Первая точка основания</param>
    /// <param name="B">Вторая точка основания</param>
    /// <param name="C">Первая точка противоположной стороны</param>
    /// <param name="D">Вторая точка противоположной стороны</param>
    /// <returns>Высота трапеции</returns>
    private static double getHeight(Point A, Point B, Point C, Point D)
    {
        double dirX = B.x - A.x;
        double dirY = B.y - A.y;
        double acX = C.x - A.x;
        double acY = C.y - A.y;

        double area = Math.Abs(dirX * acY - dirY * acX);
        double baseLength = Math.Sqrt(dirX * dirX + dirY * dirY);

        return area / baseLength;
    }

    /// <summary>
    /// Проверяет, находится ли точка на границе фигуры
    /// </summary>
    /// <param name="points">Массив точек фигуры</param>
    /// <param name="point">Проверяемая точка</param>
    /// <returns>True если точка находится на границе</returns>
    public bool isPointOnBorder(Point[] points, Point point)
    {
        return isPointOnLine(points[0], points[1], point) ||
               isPointOnLine(points[1], points[2], point) ||
               isPointOnLine(points[2], points[3], point) ||
               isPointOnLine(points[3], points[0], point);
    }

    /// <summary>
    /// Проверяет, находится ли точка внутри фигуры
    /// </summary>
    /// <param name="points">Массив точек фигуры</param>
    /// <param name="point">Проверяемая точка</param>
    /// <returns>True если точка находится внутри фигуры</returns>
    public bool isPointInside(Point[] points, Point point)
    {
        int count = 0;

        for (int i = 0; i < 4; i++)
        {
            var a = points[i];
            var b = points[(i + 1) % 4];

            if ((a.y > point.y) != (b.y > point.y) && point.x < (b.x - a.x) * (point.y - a.y) / (b.y - a.y + 1e-10) + a.x)
            {
                count++;
            }
        }

        return count % 2 == 1;
    }

    /// <summary>
    /// Проверяет, находится ли точка на отрезке между двумя точками
    /// </summary>
    /// <param name="p1">Первая точка отрезка</param>
    /// <param name="p2">Вторая точка отрезка</param>
    /// <param name="point">Проверяемая точка</param>
    /// <returns>True если точка находится на отрезке</returns>
    private bool isPointOnLine(Point p1, Point p2, Point point)
    {
        double cross = (point.y - p1.y) * (p2.x - p1.x) - (point.x - p1.x) * (p2.y - p1.y);
        if (cross != 0) return false;

        double dot = (point.x - p1.x) * (p2.x - p1.x) + (point.y - p1.y) * (p2.y - p1.y);
        if (dot < 0) return false;

        double lenSq = (p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y);
        return dot <= lenSq;
    }
}