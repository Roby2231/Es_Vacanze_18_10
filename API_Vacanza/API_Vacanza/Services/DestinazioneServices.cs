using API_Vacanza.Context;
using API_Vacanza.Models;
using API_Vacanza.Repositories;

namespace API_Vacanza.Services
{
    public class DestinazioneServices : IServices<DestinazioneDTO>
    {
        private readonly DestinazioneRepo _repository;

        public DestinazioneServices(DestinazioneRepo repo)
        {
            _repository = repo;
        }
        public bool Aggiorna(DestinazioneDTO entity)
        {
            throw new NotImplementedException();
        }

        public DestinazioneDTO? CercaPerCodice(string codice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DestinazioneDTO> CercaTutti()
        {
            ICollection<DestinazioneDTO> risultato = new List<DestinazioneDTO>();

            IEnumerable<Destinazione> elencoDestinazioni = _repository.GetAll();
            foreach (Destinazione destinazione in elencoDestinazioni)
            {
                DestinazioneDTO temp = new DestinazioneDTO()
                {
                    CodDes = destinazione.CodiceDes,
                    Nom = destinazione.Nome,
                    Des = destinazione.Descrizione,
                    Pae = destinazione.Paese,
                    Img = destinazione.ImgURL,
                };

                risultato.Add(temp);
            }

            return risultato;
        }


        public bool Elimina(string codice)
        {
            throw new NotImplementedException();
        }

        public bool Inserisci(DestinazioneDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}



