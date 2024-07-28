using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppCRUD7.Shared
{
    public class Movimiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public double Cantidad { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
