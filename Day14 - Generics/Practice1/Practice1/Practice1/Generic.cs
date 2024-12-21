public class Generic<T> 
{
    public T[] GenericSwap(T[] arr, T item1, T item2)
    {
        if (arr == null)
            return null;

        if (arr.Contains(item1) && arr.Contains(item2))
        {
            int x = 0, y = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item1))
                    x = i;
                else if (arr[i].Equals(item2))
                    y = i;
            }
            T temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        return arr;
    }


    public T FindMaximum<T>(T[] arr) where T : IComparable<T>
    {
        if (arr == null || arr.Length == 0) return default;
        if (arr.Length == 1) return arr[0];

        T max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (max.CompareTo(arr[i]) < 0)
                max = arr[i];
        }
        return max;
    }
}