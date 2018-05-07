using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    class DepartmentRepository:AbstractRepository<Department>
    {
        public DepartmentRepository(HospitalContext db) : base(db)
        {
        }
    }
}
