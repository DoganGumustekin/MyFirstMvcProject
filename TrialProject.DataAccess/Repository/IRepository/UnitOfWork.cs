using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialProject.DataAccess.DBContext;

namespace TrialProject.DataAccess.Repository.IRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TrialEFContextMVC _trialEFContextMVC;
        public IPhonexRepository Phonex { get; private set; }
        public UnitOfWork(TrialEFContextMVC trialEFContextMVC)
        {
            _trialEFContextMVC = trialEFContextMVC;
            Phonex = new PhonexRepository(_trialEFContextMVC);
        }

        public void Save()
        {
            _trialEFContextMVC.SaveChanges();
        }
    }
}
