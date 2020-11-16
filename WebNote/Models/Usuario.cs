using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebNote.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public String Sexo { get; set; }

        public String Email { get; set; }

        public String Senha { get; set; }

        public ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();
        public ICollection<Compromisso> Compromissos { get; set; } = new List<Compromisso>();
    }
}
