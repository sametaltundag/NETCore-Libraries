using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.DIPGoodAndBad
{
    public class ProductService
    {
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }

    public class ProductRepositoryFromSqlServer
    {
        public List<string> GetAll()
        {
            return new List<string>() { "SQL SERVER Kalem1", "SQL SERVER Kalem2" };
        }
    }

    public interface IRepository
    {
        public List<string> GetAll();
    }
}
