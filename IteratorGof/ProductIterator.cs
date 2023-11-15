namespace IteratorGof
{
    public class ProductIterator : IProductIterator
    {
        private ProductCollection _products;
        public int _index = 0;
        public int _stepSize { get; set; }
        public bool IsContinue { get { return _index < _products.Count; } }

        public ProductIterator(ProductCollection productCollection)
        {
            _products = productCollection;
        }
        public Product Current()
        {
            return _products[_index];
        }

        public Product First()
        {
            _index = 0;
            return _products[_index];
        }

        public IProductIterator GetIterator()
        {
            throw new NotImplementedException();
        }

        public Product MoveNext()
        {
            _index += _stepSize;
            if (IsContinue)
            {
                return _products[_index];
            }
            else
            {
                return null;
            }
        }

        public Product Previous()
        {
            _index -= _stepSize;
            if (_index >= 0)
            {
                return _products[_index];
            }
            else
            {
                return null;
            }
        }
    }
}