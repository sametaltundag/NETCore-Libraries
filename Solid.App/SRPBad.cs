using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SRP.Bad
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> ProductsList = new List<Product>();
        public List<Product> GetProducts => ProductsList;

        public Product()
        {
            ProductsList = new()
            {
                new () {Id = 1,Name = "Product 1"},
                new () {Id = 2,Name = "Product 2"},
                new () {Id = 3,Name = "Product 3"},
                new () {Id = 4,Name = "Product 4"}
            };
        }


        // Alttaki kodlar SOLID prensiplerinin dışındadır

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = ProductsList.Any(p => p.Id == product.Id);

            if(!hasProduct)
            {
                ProductsList.Add(product);
            }
            else
            {
                var index = ProductsList.FindIndex(x=> x.Id == product.Id);
                ProductsList[index] = product;
            }
        }

        public void Delete(int id)
        {
            var hasProduct = ProductsList.Find(x=>x.Id == id);

            if (hasProduct == null)
            {
                throw new Exception("Ürün bulunamadı.");
            }

            ProductsList.Remove(hasProduct);
        }

        public void WriteToConsole()
        {
            ProductsList.ForEach(x =>
            {
                Console.WriteLine($"{x.Id} - {x.Name}");
            });
        }
    }
}
