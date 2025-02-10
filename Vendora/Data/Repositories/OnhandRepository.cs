using DomainLayer.Models;
using Vendora.Data;
using Vendora.Data.Repositories;

namespace InfastructureLayer.Repositories
{
    public class OnhandRepository : Repository<OnhandProducts>, IOnhandRepository
    {
        private AppDbContext _db;
        public OnhandRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OnhandProducts obj)
        {
            _db.OnhandProducts.Update(obj);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
