using System.Collections.Generic;
using GamesStore.Domain.Entities;

namespace GamesStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        Product DeleteProduct(int productID);
        void SaveProduct(Product product);
    }
}
