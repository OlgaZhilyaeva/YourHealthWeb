using System.Collections.Generic;
using YourHealthWeb.Models;

namespace YourHealthWeb.Contracts.Core
{
    public interface IMedicineProvider
    {
        void Create(Medicine temperature);

        void Delete(int id);

        Medicine GetById(int id);

        IEnumerable<Medicine> GetAll();
    }
}
