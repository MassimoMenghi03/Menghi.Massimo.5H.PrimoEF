using System.ComponentModel.DataAnnotations;

namespace Menghi.Massimo._5H.PrimoEF.Models
{
    public class Persona
    {
        [Key]
        public int PersonaId{ get; set; }
        public string Nome{ get; set; }
        public string Cognome{ get; set; }

        [EmailAddress]
        public string EMail{ get; set; }
    }
}