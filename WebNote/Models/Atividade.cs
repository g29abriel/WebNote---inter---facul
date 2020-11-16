using System;
using System.ComponentModel.DataAnnotations;


namespace WebNote.Models
{
    public class Atividade
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Display(Name = "Horário")]
        [DataType(DataType.Time)]
        public DateTime Horario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
