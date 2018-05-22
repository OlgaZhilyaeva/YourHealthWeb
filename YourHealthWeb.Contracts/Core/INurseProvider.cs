using System.Collections.Generic;
using YourHealthWeb.Models;

namespace YourHealthWeb.Contracts.Core
{
    public interface INurseProvider
    {
        void Create(Nurse temperature);

        void Delete(int id);

        Nurse GetById(int id);

        IEnumerable<Nurse> GetAll();
    }
}
