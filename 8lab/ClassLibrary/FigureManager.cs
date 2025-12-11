using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;

public class FigureManager
{
    private List<IFigure> figures = new List<IFigure>();
    public List<IFigure> Figures => figures;

    public void LoadFromFile(string filePath)
    {
        figures.Clear();
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                if (parts.Length == 8)
                {
                    Point[] points = new Point[4];
                    for (int i = 0; i < 4; i++)
                    {
                        double x = double.Parse(parts[i * 2]);
                        double y = double.Parse(parts[i * 2 + 1]);
                        points[i] = new Point(x, y);
                    }
                    Square square = new Square(points);
                    figures.Add(square);
                }
                else if (parts.Length == 4)
                {
                    double x = double.Parse(parts[0]);
                    double y = double.Parse(parts[1]);
                    double radius = double.Parse(parts[2]);
                    string color = parts[3];

                    Circle circle = new Circle(x, y, radius, color);
                    figures.Add(circle);
                }
            }
            catch
            {
                continue;
            }
        }
    }

    public List<IFigure> GetFiguresSortedByArea()
    {
        List<IFigure> sorted = new List<IFigure>(figures);
        for (int i = 0; i < sorted.Count - 1; i++)
        {
            for (int j = 0; j < sorted.Count - i - 1; j++)
            {
                if (sorted[j].Area > sorted[j + 1].Area)
                {
                    IFigure temp = sorted[j];
                    sorted[j] = sorted[j + 1];
                    sorted[j + 1] = temp;
                }
            }
        }
        return sorted;
    }

    public List<double> GetPerimetersOfSquaresInMultipleQuadrants()
    {
        List<double> perimeters = new List<double>();
        foreach (IFigure f in figures)
        {
            if (f is Square s && !s.IsInOneTerm())
            {
                perimeters.Add(s.GetPerimeter());
            }
        }
        return perimeters;
    }

    public List<double> GetCircleLengthsDescending()
    {
        List<double> lengths = new List<double>();
        foreach (IFigure f in figures)
        {
            if (f is Circle c)
            {
                lengths.Add(c.CircleLength());
            }
        }

        for (int i = 0; i < lengths.Count - 1; i++)
        {
            for (int j = 0; j < lengths.Count - i - 1; j++)
            {
                if (lengths[j] < lengths[j + 1])
                {
                    double temp = lengths[j];
                    lengths[j] = lengths[j + 1];
                    lengths[j + 1] = temp;
                }
            }
        }
        return lengths;
    }

    public List<(string info, string color)> GetFiguresInfo()
    {
        List<(string info, string color)> result = new List<(string info, string color)>();
        foreach (IFigure f in figures)
        {
            string info = f.GetInfo();
            string color = null;
            if (f is Circle c)
            {
                color = c.Color;
            }
            result.Add((info, color));
        }
        return result;
    }

}
