using System;
using System.Collections.Generic;
using GamesStore.Domain.Abstract;
using GamesStore.Domain.Entities;

namespace GamesStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
