using API_Vacanza.Context;
using API_Vacanza.Models;

namespace API_Vacanza.Repositories
{
    public class PacchettoRepo : IRepoLettura<Pacchetto>, IRepoScrittura<Pacchetto>
    {
        private readonly VaContext _context;

        public PacchettoRepo(VaContext context)
        {
            _context = context;
        }
        public bool Create(Pacchetto entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pacchetto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pacchetto? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pacchetto entity)
        {
            throw new NotImplementedException();
        }
    }
}
