using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Clinica
    {
        public int id {  get; set; }
        public string Name { get; set; }
        public List<Usuario>? usuarios { get; set; }
    }
}
