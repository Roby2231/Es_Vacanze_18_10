using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vacanza.Models
{
    [Table("Destinazione_Pacchetto")]
    public class DestinazionePacchetto
    {
        [Key]
        public int Destinazione_paccID { get; set; }
        public int DestinazioneRIF { get; set; }
        public Destinazione? Dest { get; set; }
        public int PacchettoRIF { get; set; }
        public Pacchetto? Pacc { get; set; }
        
    }
}
