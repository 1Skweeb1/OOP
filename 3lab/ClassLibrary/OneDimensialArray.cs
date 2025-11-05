namespace ClassLibrary;
public class OneDimensialArray
{
    private int[] Array { get; set; }
    private int length { get; set; }
    
    public Array this[int index]
    {
        get => Array;
        set => Array[index] = Convert.ToInt32(value);
    }

    public OneDimensialArray()
    {
    }

    public void EnterLength()
    {
        Console.WriteLine("Введите длину массива: ");
        length = int.Parse(Console.ReadLine());
        Array = new int[length];
        Console.WriteLine("----------------------------------------");
    }
    public void EnterArray()
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Введите " + i + " элемент массива: ");
            Array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("----------------------------------------");
    }

    public static OneDimensialArray[] Clone(OneDimensialArray[] arrays)
    {
        OneDimensialArray[] clone1 = new OneDimensialArray[arrays.Length];
        for(int i = 0; i < arrays.Length; i++)
        {
            OneDimensialArray clone = new OneDimensialArray();
            clone.length = arrays[i].length;
            if (arrays[i].Array != null)
            {
                clone.Array = (int[])arrays[i].Array.Clone();
            }
            clone1[i] = clone;
        }
        
        return clone1;
    }

    public void PrintArray()
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write(Array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
    }

    public static int SumOfNegativeElements(params OneDimensialArray[] arrays)
    {
        int sum = 0;
        foreach (OneDimensialArray array in arrays)
        {
            for (int i = 0; i < array.length; i++)
            {
                if (array.Array[i] < 0)
                {
                    sum += array.Array[i];
                }
            }
        }

        return sum;
    }

    public static OneDimensialArray ReplaceNegativeElements(OneDimensialArray array, int value)
    {
        for (int i = 0; i < array.length; i++)
        {
            if (array.Array[i] < 0 && array.Array[i] != value)
            {
                bool isContain = false;

                for (int j = i + 1; j < array.length; j++)
                {
                    if (array.Array[i] == array.Array[j])
                    {
                        isContain = true;
                        array.Array[j] = value;
                    }
                }

                if (isContain)
                {
                    array.Array[i] = value;
                }
            }
        }
        return array;
    }
    
    public static OneDimensialArray operator *(OneDimensialArray arr, int n)
    {
        for (int i = 0; i < arr.length; i++)
        {
            arr.Array[i] *= n;
        }
        return arr;
    }

    public static int operator *(int n, OneDimensialArray arr)
    {
        for (int i = 0; i < arr.length; i++)
        {
            n *= arr.Array[i];
        }
        return n;
    }

    public static OneDimensialArray operator -(OneDimensialArray array)
    {
        for (int i = 0; i < array.length; i++)
        {
            array.Array[i] *= -1;
        }
        return array;
    }
}
