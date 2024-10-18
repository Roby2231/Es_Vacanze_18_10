using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vacanza.Models
{
    public class DestinazioneDTO
    {
        public string? CodDes { get; set; }
        public string? Nom { get; set; }
        public string? Des { get; set; }
        public string? Pae { get; set; }
        public string? Img { get; set; }
    }
}
