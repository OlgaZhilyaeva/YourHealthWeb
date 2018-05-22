using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class DepartmentRepository:AbstractRepository<Department>
    {
        public DepartmentRepository(HospitalContext db) : base(db)
        {
        }
    }
}
