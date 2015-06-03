using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gromero.Seguridad.Negocio.Comunes
{
    /// <summary>
    /// Representa un Objeto que es Recursivo
    /// </summary>
    public interface IRecursivo
    {
        string ID { get; set; }
        int Nivel { get; set; }
        string IdPadre { get; set; }
    }
}
