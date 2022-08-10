using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeash;
        private Dictionary<string, CatFood> _catFood;

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogLeash = new Dictionary<string, DogLeash>();
            _catFood = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            if (product is DogLeash)
            {
                _dogLeash.Add(product.Name, product as DogLeash);
            }
            if (product is CatFood)
            {
                _catFood.Add(product.Name, product as CatFood);
            }
            _products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeash[name];
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
