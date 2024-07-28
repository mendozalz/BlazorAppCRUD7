using BlazorAppCRUD7.Client.Pages;
using BlazorAppCRUD7.Server.Data;
using BlazorAppCRUD7.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD7.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("ConexionServidor")]
        public async Task<ActionResult<string>> GetEjemplo()
        {
            return "Conectado con el servidor...";
        }

        [HttpGet]
        [Route("ConexionDB")]
        public async Task<ActionResult<string>> GetConexionDB()
        {
            try
            {
                var consulta = await _context.Usuarios.ToListAsync();
                return "Conectado con la Tabla de Usuarios";
            }
            catch (Exception ex)
            {
                return "No conectado con la Tabla de Usuarios";
            }
        }

        [HttpPost("NuevoUsuario")]
        public async Task<ActionResult<string>> CreateUsuario(Usuario objeto)
        {
            _context.Usuarios.Add(objeto);
            await _context.SaveChangesAsync();
            return "El usuario ha sido guardado con Extio!!!";
        }

        [HttpGet("ObtenerUsuarios")]

        public async Task<ActionResult<List<Usuario>>> GetUsuarios()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            return usuarios;
        }

    }
}
