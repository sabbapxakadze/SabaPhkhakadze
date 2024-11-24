public class BSTree<T> where T : IComparable<T>
{
    T Value { get; set; }
    public BSTree<T> left { get; set; }
    public BSTree<T> right { get; set; }
    public BSTree(T value)
    { 
        Value = value;
        left = null;
        right = null;
    }
    public BSTree(T value, BSTree<T> left, BSTree<T> right)
    {
        Value = value;
        this.left = left;
        this.right = right;
    }
    public BSTree<T>? Search(BSTree<T> t, T item)
    {
        if (t.Value.CompareTo(item) < 0)
            return Search(t.right, item);
        else if (t.Value.CompareTo(item) > 0)
            return Search(t.left, item);
        else if (t.Value.CompareTo(item) == 0)
            return t;
        return null;
    }
    public BSTree<T>? AddItem(BSTree<T> t, T item)
    {
        if (t == null) return new BSTree<T>(item);

        else if (t.Value.CompareTo(item) > 0)
            return new BSTree<T>(t.Value, AddItem(t.left, item), t.right);
        else if (t.Value.CompareTo(item) < 0)
            return new BSTree<T>(t.Value, t.left, AddItem(t.right, item));

        return t;
    }
}