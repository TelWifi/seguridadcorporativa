using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
    public class TipoUsuarioInfoList : List<TipoUsuarioInfo>
    {

        private TipoUsuarioInfoList()
        {

        }

        public static TipoUsuarioInfoList GetTipoUsuarioInfoList()
        {
            var obj = new TipoUsuarioInfoList();
            obj.Add(new TipoUsuarioInfo { Codigo = "E", Descripcion = "Usuario Externo" });
            obj.Add(new TipoUsuarioInfo { Codigo = "I", Descripcion = "Usuario Interno" });
            return obj;
        }

    }
}
