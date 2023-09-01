using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AMS.Data;
using AMS.Models;
using Microsoft.AspNetCore.Http;
using System.Data;


namespace AMS.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AmsContext _context;

        public UsuariosController(AmsContext context)
        {
            _context = context;
        }

        private string GetRole(int usuarioID)
        {
            var nombreRole =
                from roles in _context.Roles
                join usuarios_roles in _context.UsuariosRoles
                on roles.RoleID equals usuarios_roles.RoleID
                where usuarios_roles.UsuarioID == usuarioID
                select new
                {
                    roles.Rol_Nombre
                };
            return nombreRole.ToList().ElementAt(0).Rol_Nombre;
        }

        //Login
        public async Task<IActionResult> Login(string username, string password)
        {
            if (username == null || password == null)
            {
                return View("Login");
            }

            /*var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.NombreUsuario == username && m.UpdatePassword == password);*/

            Usuario usuario = null;
            foreach(var usr in _context.Usuarios.ToList())
            {
                if(usr.NombreUsuario == username && usr.UpdatePassword == password)
                {
                    usuario = usr;
                    break;
                }
            }

            if (usuario == null)
            {
                return View("Login");
            }

            //username != null && password != null && username.Equals("acc1") && password.Equals("123")
            if (usuario != null)
            {
                HttpContext.Session.SetString("username", usuario.NombreUsuario);
                HttpContext.Session.SetString("usuarioid", usuario.UsuarioID.ToString());
                HttpContext.Session.SetString("nombrerole", GetRole(usuario.UsuarioID));
                HttpContext.Session.SetString("nombre",  string.Format("{0} {1}", usuario.Primer_Nombre, usuario.Segundo_Nombre));
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login", "User");
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuarioID == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsuarioID,NombreUsuario,Numero_Documento,Razon_Social,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Correo,UpdatePassword,Tipo_DocumentoID,Tipo_personaID,Estado,Fecha_Ultima_Modificacion")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuarioID,NombreUsuario,Numero_Documento,Razon_Social,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Correo,UpdatePassword,Tipo_DocumentoID,Tipo_personaID,Estado,Fecha_Ultima_Modificacion")] Usuario usuario)
        {
            if (id != usuario.UsuarioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UsuarioID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuarioID == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.UsuarioID == id);
        }
    }
}
