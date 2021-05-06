using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MenuRistorante.Data
{
    public class PiattiRistorante
    {
        /// <summary>Classe che descrive la struttura dati di un Piatto.</summary>

        [Key]
        public int IdPiatto { get; set; }

        [Required(ErrorMessage = "Devi nominare il piatto ! ")]
        public string NomePiatto { get; set; }

        [Required(ErrorMessage = "Devi selezionare il tipo di piatto ! ")]
        public string TipoPiatto { get; set; }

        [Required(ErrorMessage = "Devi selezionare un tipo di allergeno ! ")]
        public string AllergeniContenuti { get; set; }

        [Required(ErrorMessage = "Devi selezionare la stagione del piatto ! ")]
        public string StagionePiatto { get; set; }

        [Required(ErrorMessage = "Devi inserire il prezzo del piatto ! ")]
        public decimal PrezzoPiatto { get; set; }

        public string DescizionePiatto { get; set; }

        [Required(ErrorMessage = "Devi inserire un indirizzo di consegna ! ")]
        public string IndirizzoConsegna { get; set; }
    }
}
