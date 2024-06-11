using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServEMedico
{
    public interface ISvEMedico
    {
        //READS
        List<EMedico> GetALLEMedico();
        public EMedico GetEMedicoById(int id);
        //WRITES
        public EMedico AddEMedico(EMedico eMedico);
        public EMedico UpdateEMedico(int id, EMedico eMedico);
        public void DeleteEMedico(int id);
    }
}
