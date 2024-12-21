public class Stack<T>
{
    public int Top { get; set; }
    public T[] StackArray { get; private set; }

    public Stack(int size)
    {
        StackArray = new T[size];
        Top = -1;
    }
    public Stack(T item, int size)
    {
        StackArray = new T[size];
        StackArray[0] = item;
        Top = 0;
    }
    public void Push(T item)
    {
        if (Top < StackArray.Length - 1)
        {
            StackArray[Top++] = item;
        }
        else Console.WriteLine("Can't add item in a full stack");
    }
    public T Pop()
    {
        if (Top != -1)
        {
            var item = StackArray[Top];
            StackArray[Top--] = default(T);
            return item;
        }    
        else
        {
            Console.WriteLine("Nothing to Pop!");
            return default(T);
        }
    }
}