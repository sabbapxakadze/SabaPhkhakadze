public class DataPipeline<T, TResult>
{

    private List<Func<T, bool>> filters = new List<Func<T, bool>>();
    private Func<T, TResult> transformer;

    public void AddFilter(Func<T, bool> filter)
    {
        filters.Add(filter);
    }
    public void SetTransform(Func<T, TResult> transformer)
    {
        this.transformer = transformer;
    }

    public List<TResult> Process(IEnumerable<T> input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));
        if (transformer == null) throw new Exception("Transformer logic not provided!");

        return input.Select(transformer).ToList();
    }
}