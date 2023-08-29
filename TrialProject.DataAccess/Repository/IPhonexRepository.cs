using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialProject.DataAccess.Repository.IRepository;
using TrialProject.Models;

namespace TrialProject.DataAccess.Repository
{
    public interface IPhonexRepository : IRepository<PhoneModel>
    {
        void Update(PhoneModel phone);
    }
}
