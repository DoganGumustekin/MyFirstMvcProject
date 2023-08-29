using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialProject.DataAccess.DBContext;
using TrialProject.Models;

namespace TrialProject.DataAccess.Repository
{
    public class PhonexRepository : Repository<PhoneModel>, IPhonexRepository
    {
        private TrialEFContextMVC _trialEFContextMVC;
        public PhonexRepository(TrialEFContextMVC trialEFContextMVC) : base(trialEFContextMVC)
        {
            _trialEFContextMVC = trialEFContextMVC;
        }

        public void Update(PhoneModel phone)
        {
            _trialEFContextMVC.Update(phone);
        }
    }
}
