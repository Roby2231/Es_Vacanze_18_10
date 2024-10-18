using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vacanza.Models
{
    public class PacchettoDTO
    {
        public string? CodPac { get; set; }
        public string? Nom { get; set; }
        public decimal Pre { get; set; }
        public int Dur { get; set; } = 0;
        public DateOnly? DtIn { get; set; }
        public DateOnly? DtFi { get; set; }


    }
}
