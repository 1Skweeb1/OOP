namespace ClassLibrary
{
    public class Square : IFigure
    {
        
        Point[] Points;
        public double Area => GetArea();
        public string GetInfo()
        {
            string vertices = string.Join(", ", Points.Select(p => $"({p.X}, {p.Y})"));
            double area = Math.Round(Area, 2);
            double perimeter = Math.Round(GetPerimeter(), 2);
            return $"Square: Vertices: {vertices}; Area: {area}; Perimeter: {perimeter}";
        }

        public Square(Point[] Points)
        {
            if (Points.Length != 4)
                throw new ArgumentException("Квадрат должен иметь 4 вершины");
            this.Points = Points;
        }

        public double GetArea()
        {
            return Math.Pow((Math.Abs(Points[0].X - Points[1].X) + Math.Abs(Points[0].Y - Points[1].Y)), 2);
        }
        
        public double GetPerimeter()
        {
            return 4 * (Math.Abs(Points[0].X - Points[1].X) + Math.Abs(Points[0].Y - Points[1].Y));
        }

        public bool IsInOneTerm()
        {
            int quadrant = 0;

            foreach (Point p in Points)
            {
                if (p.X == 0 || p.Y == 0)
                    continue;

                int q = 0;

                if (p.X > 0 && p.Y > 0) q = 1;
                else if (p.X < 0 && p.Y > 0) q = 2;
                else if (p.X < 0 && p.Y < 0) q = 3;
                else if (p.X > 0 && p.Y < 0) q = 4;
                else return false;

                if (quadrant == 0)
                    quadrant = q; 
                else if (quadrant != q)
                    return false; 
            }

            return true; 
        }
        
        public double this[int index]
        {
            get
            {
                int pointIndex = index / 2;      
                bool isX = (index % 2 == 0);   

                return isX ? Points[pointIndex].X : Points[pointIndex].Y;
            }
        }
    }
}
