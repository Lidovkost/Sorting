public static class Sorting
{
public static void SelectionSort(int[] array)
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
    
}
}
