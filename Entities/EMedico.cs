using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EMedico
    {
        public int Id {  get; set; }
        public string HistorialClinico {  get; set; }
        public string Alergias { get; set; }
        public string GrupoSanguineo {  get; set; }
        public int UsuarioId { get; set; }
        public Usuario? usuario { get; set; }
    }
}
