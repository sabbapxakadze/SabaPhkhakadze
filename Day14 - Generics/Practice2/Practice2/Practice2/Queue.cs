public class Queue<T>
{
    public int Top { get; set; }
    public T[] queue { get; private set; }

    public Queue(int size)
    {
        queue = new T[size];
        Top = -1;
    }
    public Queue(T item, int size)
    {
        if (size > 0 && item != null)
        {
            queue = new T[size];
            queue[0] = item;
            Top = 0;
        }
    }
    public void Enqueue(T item)
    {
        if (Top == queue.Length - 1)
            Console.WriteLine("Queue is full, can not enqueue here!");
        else
        {
            queue[Top++] = item;
        }
    }
    public T Dequeue()
    {
        if (Top == -1)
        {
            Console.WriteLine("Nothing in queue to remove!");
            return default(T);
        }
        else
        {
            var x = queue[0];
            for (int i = 0; i < Top - 1; i++)
            {
                queue[i] = queue[i + 1];
            }
            queue[Top--] = default(T);
            return x;
        }
    }

    public T Peek()
    {
        if (Top != -1)
            return queue[Top];
        else
        {
            Console.WriteLine("Queue is empty!");
            return default(T);
        }
    }
}