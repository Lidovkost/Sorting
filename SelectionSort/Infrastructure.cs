public static class Infrastructure
{
    /// <summary>
    /// Создает массив
    /// </summary>
    /// <param name="size">размер массива</param>
    /// <param name="min">минимальный порог значений</param>
    /// <param name="max">максимальный порог значений</param>
    /// <returns>заполненный массив</returns>
    public static int[] Creatarray(int size, int min = 0, int max = 11)
    {
        return Enumerable.Range(1, size)
                .Select(item=> Random.Shared.Next(min, max))
                .ToArray();        
    }
    public static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }
}