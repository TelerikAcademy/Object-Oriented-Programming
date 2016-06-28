using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Cart
{
    public class ShoppingCart
    {
        private ICollection<IProduct> productList;

        public ShoppingCart()
        {
            this.ProductList = null;
        }

        public ICollection<IProduct> ProductList
        {
            get { return this.productList; }
            set { productList = value; }
        }

        public void AddProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public bool ContainsProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public decimal TotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
