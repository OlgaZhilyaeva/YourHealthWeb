using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class TemperatureRepository:AbstractRepository<Temperature>
    {
        public TemperatureRepository(HospitalContext db) : base(db)
        {
        }
    }
}
