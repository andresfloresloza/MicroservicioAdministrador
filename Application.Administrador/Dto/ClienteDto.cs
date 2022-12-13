using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Administrador.Dto
{
    public class ClienteDto
    {
        public Guid ClienteId { get; set; }
        public string Nombre { get; set; }
        public string NombreTienda { get; set; }
        public string TipoTienda { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
