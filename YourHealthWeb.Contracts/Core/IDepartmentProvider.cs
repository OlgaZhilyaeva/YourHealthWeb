using System.Collections.Generic;
using YourHealthWeb.Models;
using YourHealthWeb.Models.enums;

namespace YourHealthWeb.Contracts.Core
{
    public interface IDepartmentProvider
    {
        void Create(Department temperature);

        void Delete(int id);

        Department GetById(int id);

        IEnumerable<Department> GetAll();

        IEnumerable<EnumClass> GetAllEnum();
    }
}
