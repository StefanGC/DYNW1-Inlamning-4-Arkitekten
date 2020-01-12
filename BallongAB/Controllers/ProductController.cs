using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BallongAB.Models;
using BallongAB.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BallongAB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        /*public IActionResult List()
        {
            ProductListViewModel productListViewModel = new ProductListViewModel()
            {
                Products = _productRepository.AllProducts,
                CurrentCategory = "Golv"
            };

            return View(productListViewModel);
        }*/
        public ViewResult List(string category)
        {
            IEnumerable<Product> product;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                product = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                product = _productRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel
            {
                Products = product,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}