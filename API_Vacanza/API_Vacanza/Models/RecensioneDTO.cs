using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vacanza.Models
{
    public class RecensioneDTO
    {
        public string CodRec { get; set; } = null!;
        public string NomUt { get; set; } = null!;
        public string? Vot { get; set; } 
        public string? Com { get; set; } 
        public DateOnly? DtRe { get; set; }
        public int PacRIF { get; set; }
        public Pacchetto? Pacc { get; set; }
    }
}
