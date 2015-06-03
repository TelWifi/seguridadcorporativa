using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csla;
using Csla.Data;
using Gromero.Seguridad.Datos;
using System.ComponentModel;
using Gromero.Seguridad.Negocio.Editables;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
    [Serializable]
    public class RecursosInfo : ReadOnlyBase<RecursosInfo>
    {
        #region Business Methods

        public string ID { get; set; }
        public string Descripcion { get; set; }
        public string RutaRecurso { get; set; }
        public int Nivel { get; set; }

        public static readonly PropertyInfo<RecursosHijos> RecursosAnidadosProperty = RegisterProperty<RecursosHijos>(c => c.RecursosAnidados, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
        public RecursosHijos RecursosAnidados
        {
            get
            {
                if (!FieldManager.FieldExists(RecursosAnidadosProperty))
                {
                    RecursosHijos.BeginGetRecursosHijos(ID,(o, e) =>
                      {
                          if (e.Error != null)
                              throw e.Error;
                          if (!FieldManager.FieldExists(RecursosAnidadosProperty))
                          {
                              RecursosAnidados = e.Object;
                          }
                      });
                    return null;
                }
                return GetProperty(RecursosAnidadosProperty);
            }
            private set
            {
                LoadProperty(RecursosAnidadosProperty, value);
                OnPropertyChanged(RecursosAnidadosProperty);
            }
        }

        #endregion

        #region Factory Methods

        public static RecursosInfo GetRecursosInfo(Recurso data)
        {
            return DataPortal.Fetch<RecursosInfo>(data);
        }

        private RecursosInfo()
        { /* require use of factory methods */ }

        #endregion

        #region Data Access

        private void DataPortal_Fetch(Recurso criteria)
        {
            ID = criteria.IdRecurso;
            Descripcion = criteria.Descripcion;
            RutaRecurso = criteria.RutaRecurso;
            Nivel = criteria.Nivel;
        }

        #endregion
    }
}
