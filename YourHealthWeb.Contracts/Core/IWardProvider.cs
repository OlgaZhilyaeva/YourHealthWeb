using System.Collections.Generic;
using YourHealthWeb.Models;
using YourHealthWeb.Models.enums;

namespace YourHealthWeb.Contracts.Core
{
    public interface IWardProvider
    {
        void Create(Ward temperature);

        void Delete(int id);

        Ward GetById(int id);

        IEnumerable<Ward> GetAll();

        IEnumerable<Ward> GetAllByDepartmentId(int id);

        IEnumerable<EnumClass> GetAllEnum();
    }
}
