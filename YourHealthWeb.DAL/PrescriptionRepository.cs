using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class PrescriptionRepository:AbstractRepository<Prescription>
    {
        public PrescriptionRepository(HospitalContext db) : base(db)
        {
        }
    }
}
