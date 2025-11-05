using ClassLibrary;

Console.WriteLine("Введите 3 целочисленных массива: ");

OneDimensialArray[] arrays = new OneDimensialArray[3];

for (int i = 0; i < 3; i++)
{
    if (i == 0) Console.WriteLine("Введите массив А: ");
    if (i == 1) Console.WriteLine("Введите массив B: ");
    if (i == 2) Console.WriteLine("Введите массив C: ");
    arrays[i] = new OneDimensialArray();
    arrays[i].EnterLength();
    arrays[i].EnterArray();
    arrays[i].PrintArray();
    Console.WriteLine();
}

OneDimensialArray[] arrays1 = new OneDimensialArray[3];
arrays1 = OneDimensialArray.Clone(arrays);
Console.WriteLine("Массив А:");
arrays1[0].PrintArray();
Console.WriteLine("Массив B:");
arrays1[1].PrintArray();
Console.WriteLine("Массив C:");
arrays1[2].PrintArray();

arrays1[0] *= 5;
Console.WriteLine("Общая сумма отрицательных элементов в массивах 5*A и С = " + OneDimensialArray.SumOfNegativeElements(arrays1[0], arrays1[2]));
Console.WriteLine("----------------------------------------");

arrays1 = OneDimensialArray.Clone(arrays);
arrays1[0] = -arrays1[0];
arrays1[1] *= 2;
arrays1[2] *= 4;
Console.WriteLine("Общая сумма отрицательных элементов в массивах  2*В, -А и С*4 = " + OneDimensialArray.SumOfNegativeElements(arrays1[0], arrays1[1], arrays1[2]));
Console.WriteLine("----------------------------------------");

arrays1 = OneDimensialArray.Clone(arrays);

if(OneDimensialArray.SumOfNegativeElements(arrays1[0]) > OneDimensialArray.SumOfNegativeElements(arrays1[1]))
{
    int sumOfNegativeElementsA = OneDimensialArray.SumOfNegativeElements(arrays1[0]);
    OneDimensialArray.ReplaceNegativeElements(arrays1[0], sumOfNegativeElementsA);
    Console.WriteLine("Замена повторяющихся отрицательных элементов в массиве А:");
    arrays1[0].PrintArray();
}
