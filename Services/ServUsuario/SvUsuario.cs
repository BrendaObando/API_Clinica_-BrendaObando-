using Entities;
using Services.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServUsuario
{
    public class SvUsuario : ISvUsuario
    {
        private MyContext _myDbContext = default!;

        public SvUsuario()
        {
            _myDbContext = new MyContext();
        }

        public Usuario AddUsuario(Usuario usuario)
        {
            _myDbContext.Usuarios.Add(usuario);
            _myDbContext.SaveChanges();
            return usuario;
        }

        public void DeleteUsuario(int id)
        {
            Usuario deleteUsuario=_myDbContext.Usuarios.Find(id);
            if(deleteUsuario is not null) 
            { 
                _myDbContext.Usuarios.Remove(deleteUsuario);
                _myDbContext.SaveChanges() ;
            }
        }

        public List<Usuario> GetALLUsuarios()
        {
            return _myDbContext.Usuarios.ToList();
        }

        public Usuario GetUsuarioById(int id)
        {
            return _myDbContext.Usuarios.Find(id);
        }

        public Usuario UpdateUsuario(int id, Usuario usuario)
        {
            Usuario updateUsuario = _myDbContext.Usuarios.Find(id);
            if (updateUsuario is not null)
            {
                updateUsuario.NombreUsuario=usuario.NombreUsuario;
                updateUsuario.Contrasena=usuario.Contrasena;
                updateUsuario.clinica=usuario.clinica;
                updateUsuario.clinicaId=usuario.clinicaId;

                _myDbContext.Usuarios.Update(updateUsuario);
                _myDbContext.SaveChanges();
            }
            return updateUsuario;
        }
    }
}
