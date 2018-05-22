using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class MedicineRepository:AbstractRepository<Medicine>
    {
        public MedicineRepository(HospitalContext db) : base(db)
        {
        }
    }
}
