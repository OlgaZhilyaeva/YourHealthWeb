using System.Collections.Generic;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Models;

namespace YourHealthWeb.Core
{
    public class UserProvider:IUserProvider
    {
        public void Create(HospitalUser temperature)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public HospitalUser GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<HospitalUser> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
