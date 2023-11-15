using System.Collections;

namespace IteratorGof
{
    public class ProductList : IEnumerable<Product>
    {
        private List<Product> _products = new List<Product>();
        public Product this[int index]
        { 
            get { return _products[index]; }
            set { _products.Add(value); }
        }

        public IEnumerator<Product> GetEnumerator()
        {
            foreach (var product in _products)
            {
                yield return product;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
