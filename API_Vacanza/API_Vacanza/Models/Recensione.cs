using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vacanza.Models
{
    [Table("Recensione")]
    public class Recensione
    {
        [Key]
        public int RecensioneID { get; set; }
        public string CodiceRec { get; set; } = null!;
        public string NomeUtente { get; set; } = null!;
        public string Voto { get; set; } = null!;
        public string? Commento { get; set; } 
        public DateOnly? DataRece { get; set; }
        public int PacchettoRIF { get; set; }
        public Pacchetto? Pacc { get; set; }   // posso accedere agli oggetti

    }
}
