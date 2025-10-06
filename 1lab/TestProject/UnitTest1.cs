using ClassLib;

namespace TestProject;

[TestFixture]
public class FigureTests
{
    [Test]
    public void IsTrapezoidWhenValidTrapezoidReturnsTrue()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(3, 3),
            new Point(1, 3)
        };

        var figure = new Figure(points);

        Assert.That(figure.isTrapezoid(points), Is.True);
    }

    [Test]
    public void IsTrapezoidWhenNotTrapezoidReturnsFalse()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(2, 1),
            new Point(3, 3),
            new Point(1, 4)
        };

        var figure = new Figure(points);

        Assert.That(figure.isTrapezoid(points), Is.False);
    }

    [Test]
    public void IsTrapezoidWhenThreePointsReturnsFalse()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(2, 3)
        };

        var figure = new Figure(points);

        Assert.That(figure.isTrapezoid(points), Is.False);
    }

    [Test]
    public void IsTrapezoidWhenDuplicatePointsReturnsFalse()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(0, 0),
            new Point(3, 3),
            new Point(1, 3)
        };

        var figure = new Figure(points);

        Assert.That(figure.isTrapezoid(points), Is.False);
    }

    [Test]
    public void GetSideLengthReturnsCorrectValue()
    {
        var p1 = new Point(0, 0);
        var p2 = new Point(3, 4);

        double length = Figure.getSideLength(p1, p2);

        Assert.That(length, Is.EqualTo(5).Within(1e-6));
    }

    [Test]
    public void GetPerimeterReturnsCorrectValue()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 3),
            new Point(0, 3)
        };

        double perimeter = Figure.getPerimeter(points);

        Assert.That(perimeter, Is.EqualTo(14).Within(1e-6));
    }

    [Test]
    public void GetAreaWhenTrapezoidReturnsCorrectValue()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(3, 3),
            new Point(1, 3)
        };

        double area = Figure.getArea(points);

        Assert.That(area, Is.EqualTo(9).Within(1e-6));
    }

    [Test]
    public void GetAreaWhenRectangleReturnsCorrectValue()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 2),
            new Point(0, 2)
        };

        double area = Figure.getArea(points);

        Assert.That(area, Is.EqualTo(8).Within(1e-6));
    }

    [Test]
    public void IsPointInsideWhenPointInsideReturnsTrue()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 3),
            new Point(0, 3)
        };
        var figure = new Figure(points);
        var point = new Point(2, 1);

        Assert.That(figure.isPointInside(points, point), Is.True);
    }

    [Test]
    public void IsPointInsideWhenPointOutsideReturnsFalse()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 3),
            new Point(0, 3)
        };
        var figure = new Figure(points);
        var point = new Point(5, 5);

        Assert.That(figure.isPointInside(points, point), Is.False);
    }

    [Test]
    public void IsPointInsideWhenPointOnBorderReturnsFalse()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 3),
            new Point(0, 3)
        };
        var figure = new Figure(points);
        var point = new Point(2, 0);

        Assert.That(figure.isPointInside(points, point), Is.True);
    }

    [Test]
    public void IsPointOnBorderWhenPointOnSideReturnsTrue()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 3),
            new Point(0, 3)
        };
        var figure = new Figure(points);
        var point = new Point(2, 0);

        Assert.That(figure.isPointOnBorder(points, point), Is.True);
    }

    [Test]
    public void IsPointOnBorderWhenPointInsideReturnsFalse()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 3),
            new Point(0, 3)
        };
        var figure = new Figure(points);
        var point = new Point(2, 1);

        Assert.That(figure.isPointOnBorder(points, point), Is.False);
    }

    [Test]
    public void IsPointOnBorderWhenPointOutsideReturnsFalse()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 3),
            new Point(0, 3)
        };
        var figure = new Figure(points);
        var point = new Point(5, 5);

        Assert.That(figure.isPointOnBorder(points, point), Is.False);
    }

    [Test]
    public void ConstructorWithPointsArrayInitializesCorrectly()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(1, 0),
            new Point(1, 1),
            new Point(0, 1)
        };

        var figure = new Figure(points);

        Assert.That(figure, Is.Not.Null);
    }

    [Test]
    public void GetAreaWhenComplexTrapezoidReturnsCorrectValue()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(6, 0),
            new Point(4, 4),
            new Point(2, 4)
        };

        double area = Figure.getArea(points);

        Assert.That(area, Is.EqualTo(16).Within(1e-6));
    }

    [Test]
    public void IsPointInsideWithComplexShapeReturnsCorrectResult()
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(3, 0),
            new Point(3, 2),
            new Point(0, 3)
        };
        var figure = new Figure(points);
        var insidePoint = new Point(1, 1);
        var outsidePoint = new Point(2, 2.5);

        Assert.That(figure.isPointInside(points, insidePoint), Is.True);
        Assert.That(figure.isPointInside(points, outsidePoint), Is.False);
    }
}