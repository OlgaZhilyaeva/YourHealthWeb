using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class NurseRepository : AbstractRepository<Nurse>
    {
        public NurseRepository(HospitalContext db) : base(db)
        {
        }
    }
}
