using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class HospitalRepository:AbstractRepository<Hospital>
    {
        public HospitalRepository(HospitalContext db) : base(db)
        {
        }
    }
}
