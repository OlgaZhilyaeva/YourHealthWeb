using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class UserRepository:AbstractRepository<HospitalUser>
    {
        public UserRepository(HospitalContext db) : base(db)
        {
        }
    }
}
