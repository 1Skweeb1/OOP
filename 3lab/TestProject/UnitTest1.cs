using ClassLibrary;

namespace TestProject;

public class OneDimensialArrayTests
{
    [Test]
    public void MultiplyOperator_ShouldScaleElements()
    {
        var arr = CreateArray(new int[] { 1, 2, 3 });
        var result = arr * 2;

        Assert.That(GetValues(result), Is.EqualTo(new int[] { 2, 4, 6 }));
    }

    [Test]
    public void UnaryMinusOperator_ShouldInvertSigns()
    {
        var arr = CreateArray(new int[] { 1, -2, 3 });
        var result = -arr;

        Assert.That(GetValues(result), Is.EqualTo(new int[] { -1, 2, -3 }));
    }

    [Test]
    public void SumOfNegativeElements_ShouldReturnCorrectSum()
    {
        var a = CreateArray(new int[] { -1, 2, -3 });
        var b = CreateArray(new int[] { 5, -5 });

        var sum = OneDimensialArray.SumOfNegativeElements(a, b);

        Assert.That(sum, Is.EqualTo(-9));
    }

    [Test]
    public void ReplaceNegativeElements_ShouldReplaceRepeatedNegatives()
    {
        var arr = CreateArray(new int[] { -2, -3, -2, 4, -2 });
        var result = OneDimensialArray.ReplaceNegativeElements(arr, 99);

        Assert.That(GetValues(result), Is.EqualTo(new int[] { 99, -3, 99, 4, 99 }));
    }

    [Test]
    public void Clone_ShouldCreateIndependentCopy()
    {
        var a = CreateArray(new int[] { 1, 2, 3 });
        var arrays = new[] { a };

        var clone = OneDimensialArray.Clone(arrays);

        Assert.That(clone[0], Is.Not.SameAs(a));
        Assert.That(GetValues(clone[0]), Is.EqualTo(GetValues(a)));
    }

    private static OneDimensialArray CreateArray(int[] values)
    {
        var arr = new OneDimensialArray();
        var arrField = typeof(OneDimensialArray).GetProperty("Array",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var lenField = typeof(OneDimensialArray).GetProperty("length",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

        lenField.SetValue(arr, values.Length);
        arrField.SetValue(arr, values);
        return arr;
    }

    private static int[] GetValues(OneDimensialArray arr)
    {
        var arrField = typeof(OneDimensialArray).GetProperty("Array",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        return (int[])arrField.GetValue(arr);
    }
}
