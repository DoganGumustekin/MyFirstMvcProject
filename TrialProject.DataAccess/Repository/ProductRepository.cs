using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialProject.DataAccess.DBContext;
using TrialProject.DataAccess.Repository.IRepository;
using TrialProject.Models;

namespace TrialProject.DataAccess.Repository
{
    public class ProductRepository : Repository<ProductModel>, IProductRepository
    {
        private TrialEFContextMVC _trialEFContextMVC;
        public ProductRepository(TrialEFContextMVC trialEFContextMVC) : base(trialEFContextMVC)
        {
            _trialEFContextMVC = trialEFContextMVC;
        }

        public void Update(ProductModel phone)
        {
            _trialEFContextMVC.Update(phone);
        }
    }
}
