using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServUsuario
{
    public interface ISvUsuario
    {
        //READS
        List<Usuario> GetALLUsuarios();
        public Usuario GetUsuarioById(int id);
        //WRITES
        public Usuario AddUsuario(Usuario usuario);
        public Usuario UpdateUsuario(int id, Usuario usuario);
        public void DeleteUsuario(int id);
    }
}
