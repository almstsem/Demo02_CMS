using System;

namespace CMS.BusinessLayer
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            // Заглушка для теста
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Yellow Sunflowers";
                product.CurrentPrice = 15.5M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}