using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialProject.Models;

namespace TrialProject.DataAccess.Repository.IRepository
{
    public interface IPhonexRepository : IRepository<PhoneModel>
    {
        void Update(PhoneModel phone);
    }
}
