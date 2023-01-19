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

private static void Swap(ref int leftElement, ref int rigthElement)
{
    int temp = leftElement;
    leftElement = rigthElement;
    rigthElement = temp;
}
private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivot = minIndex-1;
    for(int i = minIndex; i<=maxIndex; i++)
    {
        if(array[i]<array[maxIndex])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }
    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);
    return pivot;
}
    public static int[] SortQuick(this int[] array, int minIndex, int maxIndex)
    {
        if(minIndex>=maxIndex)
        {
            return array;
        }
        int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);
        SortQuick(array, minIndex, pivotIndex - 1);
        SortQuick(array, pivotIndex + 1, maxIndex);
        return array;
    }

    public static int[] Sort(this int[] collection, int left, int right)
  {
    int i = left;
    int j = right;

    int pivot = collection[Random.Shared.Next(left, right)];
    while (i <= j)
    {
      while (collection[i] < pivot) i++;
      while (collection[j] > pivot) j--;

      if (i <= j)
      {
        int t = collection[i];
        collection[i] = collection[j];
        collection[j] = t;
        i++;
        j--;
      }
    }
    if (i < right) SortQuick(collection, i, right);
    if (left < j) SortQuick(collection, left, j);
    return collection;
  }

}
