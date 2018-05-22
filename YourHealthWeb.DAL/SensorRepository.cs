using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class SensorRepository:AbstractRepository<Sensor>
    {
        public SensorRepository(HospitalContext db) : base(db)
        {
        }
    }
}
