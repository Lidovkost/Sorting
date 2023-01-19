public static class InfrastructureThis
{
    /// <summary>
    /// Создает массив
    /// </summary>
    /// <param name="size">размер массива</param>
    /// <param name="min">минимальный порог значений</param>
    /// <param name="max">максимальный порог значений</param>
    /// <returns>заполненный массив</returns>
    public static int[] CreateArray(this int size, int min = 0, int max = 11)
    {
        return Enumerable.Range(1, size)
                .Select(item=> Random.Shared.Next(min, max))
                .ToArray();        
    }
    /// <summary>
    /// Выводит массив в консоль
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="separator">разделитель</param>
    /// <returns></returns>
    public static int[] Show(this int[] array, string separator = ",")
    {
        Console.WriteLine($"[{string.Join(separator, array)}]");
        return array;
    }
   /// <summary>
   /// Создает копию массива
   /// </summary>
   /// <param name="originalArray">оригинальный массив(стартовый)</param>
   /// <returns>копию стартовго массива</returns>
    public static int[] EquatingArray(this int[] originalArray)
    {
        int size = originalArray.Length;
        int[] copyArray = new int[size];
        for(int i = 0; i<size; i++)
        {
            copyArray[i] = originalArray[i];
        }
        return copyArray;
    }
    public static bool СomparingArrays(this int[] array1, int[] array2)
    {
        int k = 0;
        for(int i = 0; i< array1.Length; i++)
        {
           if(array1[i] != array2[i])
           {
                k = 1;
           }
        }
        if(k == 1) return false;
        else return true;
    }
}