using System.Collections.Generic;
using YourHealthWeb.Models;

namespace YourHealthWeb.Contracts.Core
{
    public interface IUserProvider
    {
        void Create(HospitalUser temperature);

        void Delete(int id);

        HospitalUser GetById(int id);

        IEnumerable<HospitalUser> GetAll();
    }
}
