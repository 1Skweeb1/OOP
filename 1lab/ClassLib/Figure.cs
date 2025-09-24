namespace ClassLib;

public class Figure
{
    Point[] points;
    public Figure(Point[] points)
    {
        this.points = points;
    }

    public bool isTrapezoid(Point[] points)
    {
        if (points.Length != 4) return false;
        if (points[0] == points[1] || points[1] == points[2] || points[2] == points[3] || points[3] == points[0]) return false;
        
        if (isSidesParallel(points[0], points[1], points[2], points[3])
        || isSidesParallel(points[1], points[2], points[3], points[0])
        || isSidesParallel(points[2], points[3], points[0], points[1])) return true;

        return false;
    }

    private static bool isSidesParallel(Point p1, Point p2, Point p3, Point p4)
    {
        return (p1.x - p2.x) * (p3.y - p4.y) == (p1.y - p2.y) * (p3.x - p4.x);
    }

    public static double getSideLength(Point p1, Point p2)
    {
        return Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
    }

    public static double getPerimeter(Point[] points)
    {
        return getSideLength(points[0], points[1]) + getSideLength(points[1], points[2]) + getSideLength(points[2], points[3]) + getSideLength(points[3], points[0]);
    }

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

    public bool isPointOnBorder(Point[] points, Point point)
    {
        return isPointOnLine(points[0], points[1], point) ||
               isPointOnLine(points[1], points[2], point) ||
               isPointOnLine(points[2], points[3], point) ||
               isPointOnLine(points[3], points[0], point);
    }

    public bool isPointInside(Point[] points,Point point)
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