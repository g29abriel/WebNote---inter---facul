using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNote.Models
{
    public class Login
    {
        public String Email { get; set; }

        public String Senha { get; set; }

        public Usuario Usuario { get; set; }
    }
}
