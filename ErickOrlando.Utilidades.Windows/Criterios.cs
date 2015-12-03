using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErickOrlando.Utilidades.Windows
{
    [Serializable]
    public class Criterios
    {
        // Methods
        public Criterios()
        {
        }

        public Criterios(string mValor)
        {
            Valor = mValor;
        }

        public override string ToString()
        {
            return Valor;
        }

        // Properties
        public string Valor { get; set; }

    }
}
