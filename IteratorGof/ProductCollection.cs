namespace IteratorGof
{
    public class ProductCollection : IProductCollection
    {
        private List<Product> _products = new List<Product>();

        public int Count
        {
            get { return _products.Count; }
        }

        public Product this[int index]
        {
            get { return _products[index]; }
            set { _products.Add(value); }
        }

        public IProductIterator GetIterator()
        {
            return new ProductIterator(this);
        }
    }
}
