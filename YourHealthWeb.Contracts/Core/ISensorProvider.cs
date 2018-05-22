using System.Collections.Generic;
using YourHealthWeb.Models;
using YourHealthWeb.Models.enums;

namespace YourHealthWeb.Contracts.Core
{
    public interface ISensorProvider
    {
        void Create(Sensor temperature);

        void Delete(int id);

        Sensor GetById(int id);

        IEnumerable<Sensor> GetAll();

        IEnumerable<EnumClass> GetAllEnum();
    }
}
