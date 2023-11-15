namespace IteratorGof
{
    public interface IProductIterator
    {
        Product First();
        Product Current();
        Product MoveNext();
        Product Previous();
        bool IsContinue { get; }
    }
}