﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BallongAB.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> AllProducts 
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }  
        
        public Product GetProductById(int prodId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == prodId);
        }
    }
}
