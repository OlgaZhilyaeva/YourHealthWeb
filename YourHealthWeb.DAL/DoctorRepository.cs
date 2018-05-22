using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class DoctorRepository:AbstractRepository<Doctor>
    {
        public DoctorRepository(HospitalContext db) : base(db)
        {
        }
    }
}
