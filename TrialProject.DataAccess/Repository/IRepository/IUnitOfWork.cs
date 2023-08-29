using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialProject.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IPhonexRepository Phonex { get; }
        void Save();
    }
}
