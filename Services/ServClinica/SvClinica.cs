using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;

namespace Services.ServClinica
{
    public class SvClinica : ISvClinica
    {
        private MyContext _myDbcontext = default!;
        public SvClinica()
        {
            _myDbcontext = new MyContext();
        }

        public Clinica AddClinica(Clinica clinica)
        {
            _myDbcontext.Clinicas.Add(clinica);
            _myDbcontext.SaveChanges();
            return clinica;
        }

        public void DeleteClinica(int id)
        {
            Clinica deleteClinica= _myDbcontext.Clinicas.Find(id);
            if (deleteClinica is not null) 
            {
                _myDbcontext.Clinicas.Remove(deleteClinica);
                _myDbcontext.SaveChanges();
            }
        }

        public List<Clinica> GetALLClinica()
        {
            return _myDbcontext.Clinicas.Include(x => x.usuarios).ThenInclude(x => x.eMedico).ToList();
        }

        public Clinica UpdateClinica(int id, Clinica clinica)
        {
            Clinica updateClinica = _myDbcontext.Clinicas.Find(id);
            if(updateClinica is not null)
            {
                _myDbcontext.Clinicas.Update(updateClinica);
                _myDbcontext.SaveChanges();
            }
            return updateClinica;
        }
    }
}
