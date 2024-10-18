using API_Vacanza.Context;
using API_Vacanza.Models;

namespace API_Vacanza.Repositories
{
    public class DestinazioneRepo : IRepoLettura<Destinazione>, IRepoScrittura<Destinazione>
    {
        private readonly VaContext _context;

        public DestinazioneRepo(VaContext context)
        {
            _context = context;
        }
        public bool Create(Destinazione entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Destinazione> GetAll()
        {
            return _context.Destinazioni.ToList();
        }

        public Destinazione? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Destinazione entity)
        {
            throw new NotImplementedException();
        }
    }
}
