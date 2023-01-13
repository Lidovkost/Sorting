public static class SortingThis
{
    /// <summary>
    /// сортировка выбором
    /// </summary>
    /// <param name="массив"></param>
    /// <returns>отстортированный по возрастанию массив</returns>
public static int[] SortSelection(this int[] array)
{
    int size = array.Length;
    for(int i = 0; i<size-1;i++)
    {
        int minElement = i;
        for(int j = i+1; j<size;j++)
        {
            if(array[minElement]>array[j])
            {
                minElement = j;
            }
        }
        int memoryElement = array[i];
        array[i] = array[minElement];
        array[minElement] = memoryElement;
    }
    return array;
}

/// <summary>
/// Сортировка пузырьком
/// </summary>
/// <param name="array">массив</param>
/// <returns>отсортированный по возрастанию массив</returns>
public static int[] SortBubble(this int[] array)
{
    int size = array.Length;
    for(int j = 1; j<size-1; j++)
    {
    for(int i = 0; i<size-j; i++)
    {
        int memoryElement = array[i];
        if(array[i]>array[i+1])
        {
            array[i] = array[i+1];
            array[i+1] = memoryElement;
        }
    }
    }
    return array;
}

}
