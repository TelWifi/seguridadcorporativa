using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad.Entidades
{
    public class ResponseDTOListaUsuario : BaseResponse
    {
        public IEnumerable<ResponseInfoUsuarios> ListaUsuarios { get; set; }
    }
}
