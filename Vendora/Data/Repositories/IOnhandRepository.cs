using DomainLayer.Models;
using Vendora.Data.Repositories;

namespace InfastructureLayer.Repositories
{
    public interface IOnhandRepository:IRepository<OnhandProducts>
    {
        void Save();
        void Update(OnhandProducts obj);
    }
}