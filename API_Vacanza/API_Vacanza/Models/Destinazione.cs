﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vacanza.Models
{
    [Table("Destinazione")]
    public class Destinazione
    {
        
        [Key] // Decoratore
        public int DestinazioneID { get; set; }
        public string CodiceDes { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string? Descrizione { get; set; }
        public string Paese { get; set; } =null!;
        public string ImgURL { get; set; } = null!;

        public ICollection<DestinazionePacchetto>? DestinazionePacchetti { get; set; }
    }
}
