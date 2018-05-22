using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class WardRepository:AbstractRepository<Ward>
    {
        public WardRepository(HospitalContext db) : base(db)
        {
        }
    }
}
