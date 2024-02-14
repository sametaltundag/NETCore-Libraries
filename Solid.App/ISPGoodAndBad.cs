using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.ISPGoodAndBad
{
    // Class Library Read Impl
    // Class Library Create/Update/Delete/ Impl


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    /* Bad Way

    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(Product id);
    }
    */


    // Good and True Way
    public interface IReadRepository<T> where T : class
    {
        List<Product> GetList();
        Product GetById(int id);
    }

    public interface IWriteRepository<T> where T : class
    {
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(Product id);
    }


    // 1. Class Library
    public class ReadProductRepository : IReadRepository<Product>
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }

    // 2. Class Library
    public class WriteProductRepository : IWriteRepository<Product>
    {
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}