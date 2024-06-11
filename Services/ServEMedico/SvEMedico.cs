using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;


namespace Services.ServEMedico
{
    public class SvEMedico : ISvEMedico
    {
        private MyContext _myDbContext = default!;
        public SvEMedico() 
        {
            _myDbContext = new MyContext();
        }
        public EMedico AddEMedico(EMedico eMedico)
        {
            _myDbContext.EMedicos.Add(eMedico);
            _myDbContext.SaveChanges();
            return eMedico;
        }

        public void DeleteEMedico(int id)
        {
            EMedico deleteEMedico = _myDbContext.EMedicos.Find(id);
            if (deleteEMedico is not null) 
            { 
                _myDbContext.EMedicos.Remove(deleteEMedico);
                _myDbContext.SaveChanges();
            }
        }

        public List<EMedico> GetALLEMedico()
        {
            return _myDbContext.EMedicos.Include(x=>x.usuario).ToList();
        }

        public EMedico GetEMedicoById(int id)
        {
            return _myDbContext.EMedicos.Include(x=>x.usuario).FirstOrDefault(e=>e.Id==id);
        }

        public EMedico UpdateEMedico(int id, EMedico eMedico)
        {
            var updateEMedico = _myDbContext.EMedicos.Find(id);
            if(updateEMedico is not null)
            {
                updateEMedico.HistorialClinico=eMedico.HistorialClinico;
                updateEMedico.Alergias=eMedico.Alergias;
                updateEMedico.GrupoSanguineo=eMedico.GrupoSanguineo;
                updateEMedico.UsuarioId=eMedico.UsuarioId;

                _myDbContext.EMedicos.Update(updateEMedico);
                _myDbContext.SaveChanges(); 
            }
            return updateEMedico;
        }
    }
}
