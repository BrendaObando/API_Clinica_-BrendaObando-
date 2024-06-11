using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServClinica
{
    public interface ISvClinica
    {
        //READS
        List<Clinica> GetALLClinica();
       // Clinica GetClinicaById(int id);
        //WRITES
        public Clinica AddClinica(Clinica clinica);
        public Clinica UpdateClinica(int id, Clinica clinica);
        public void DeleteClinica(int id);
    }
}
