using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM22024VVMM.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Double Precio { get; set; } = 0;
        public string Foto { get; set; } 

    }
}
