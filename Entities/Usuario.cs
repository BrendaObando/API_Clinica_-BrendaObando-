using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }   
        public string Contrasena { get; set; }
        public int clinicaId { get; set; }
        public Clinica? clinica {  get; set; }
        public EMedico? eMedico { get; set; }
        public List<Rol>? rols { get; set; }
    }
}
