using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebNote.Models;

namespace WebNote.Data
{
    public class WebNoteContext : DbContext
    {
        public WebNoteContext (DbContextOptions<WebNoteContext> options)
            : base(options)
        {
        }

        public DbSet<WebNote.Models.Usuario> Usuario { get; set; }
    }
}
