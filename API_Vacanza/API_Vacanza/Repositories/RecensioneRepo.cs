using API_Vacanza.Context;
using API_Vacanza.Models;

namespace API_Vacanza.Repositories
{
    public class RecensioneRepo : IRepoLettura<Recensione>, IRepoScrittura<Recensione>
    {
        private readonly VaContext _context;

        public RecensioneRepo(VaContext context)
        {
            _context = context;
        }
        public bool Create(Recensione entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recensione> GetAll()
        {
            throw new NotImplementedException();
        }

        public Recensione? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Recensione entity)
        {
            throw new NotImplementedException();
        }
    }
}
