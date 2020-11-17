using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebNote.Data;

namespace WebNote.Controllers
{
    public class LoginController : Controller
    {
        private readonly WebNoteContext _context;

        public LoginController(WebNoteContext context) {
            _context = context;
        }
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(String email, String senha) {

            if (email != null && senha != null) {
                var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Senha == senha && m.Email == email);
                if(usuario != null)
                return RedirectToAction("Menu", "Usuarios");
            }
            return View();
        }
    }
}
