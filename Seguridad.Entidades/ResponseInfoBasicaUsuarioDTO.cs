using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad.Entidades
{
    public class ResponseInfoBasicaUsuarioDTO : BaseResponse
    {
        public IEnumerable<ResponseListaUsuarios> ListaInfoBasicaUsuarios { get; set; }

    }
}
