using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory {
    public class InMemoryProductDal :  IProductDal {

        List<Product> products;
        public InMemoryProductDal() {
            products = new List<Product> {

                new Product { ProductId = 1,
                    CategoryId = 1,
                    ProductName = "Bardak",
                    UnitPrice = 15 , UnitsInStock = 15 },
                new Product { ProductId = 2,
                    CategoryId = 1,
                    ProductName = "Kamera",
                    UnitPrice = 500 , UnitsInStock = 3 },
                new Product { ProductId = 3,
                    CategoryId = 2,
                    ProductName = "Telefon",
                    UnitPrice = 1500 , UnitsInStock = 2 },
                new Product { ProductId = 4,
                    CategoryId = 2,
                    ProductName = "Klavye",
                    UnitPrice = 150 , UnitsInStock = 65 },
                new Product { ProductId = 5,
                    CategoryId = 2,
                    ProductName = "Fare",
                    UnitPrice = 85 , UnitsInStock = 1 },
            };
        }
        public List<Product> GetAll() {
            return products; 
        }
        public void Add(Product product) {
            products.Add(product);
        }

        public void Delete(Product product) {
            var toDelete = products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }


        public void Update(Product product) {

            var toUpdate = products.SingleOrDefault(p => p.ProductId == product.ProductId);

            toUpdate.CategoryId = product.CategoryId;
            toUpdate.ProductName = product.ProductName;
            toUpdate.UnitsInStock = product.UnitsInStock;
            toUpdate.UnitPrice = product.UnitsInStock;

        }

        public List<Product> GetAllByCategory(int categoryId) {
            var list = products.Where(p => p.CategoryId == categoryId).ToList();
            return list;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null) {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter) {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails() {
            throw new NotImplementedException();
        }
    }
}
