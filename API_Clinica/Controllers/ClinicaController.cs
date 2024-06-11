using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace API_Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicaController : Controller
    {
        public readonly ISvClinica svClinica;

        public ClinicaController(ISvClinica svClinica)
        {
            this.svClinica = svClinica;
        }

        [HttpGet]
        public IEnumerable<Clinica> GetAllClinics()
        {
            return svClinica.GetAllClinic();

        }

        [HttpPost]
        public Clinica AddClinic([FromBody] Clinica clinic)
        {
            return svClinica.AddClinic(clinic);
        }

        [HttpPut("{id}")]
        public Clinica UpdateClinic(int id, [FromBody] Clinica clinic)
        {

            return svClinica.UpdateClinic(clinic, id);

        }

        [HttpDelete("{id}")]
        public void DeleteClinic(int id)
        {
            svClinica.DeleteClinic(id);

        }
    }
}
