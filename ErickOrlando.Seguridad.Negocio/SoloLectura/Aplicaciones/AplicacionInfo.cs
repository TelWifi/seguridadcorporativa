using Csla;
using Csla.Data;
using ErickOrlando.Seguridad.Datos;
using ErickOrlando.Seguridad.Negocio.Editables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErickOrlando.Seguridad.Negocio.SoloLectura
{
    [Serializable]
    public class AplicacionInfo : ReadOnlyBase<AplicacionInfo>
    {
        #region Business Methods

        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Acronimo { get; set; }
        public string Tipo { get; set; }
        public string Ruta { get; set; }

        public static readonly PropertyInfo<Negocio.Editables.Roles> RolesProperty = RegisterProperty<Negocio.Editables.Roles>(c => c.Roles, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
        public Negocio.Editables.Roles Roles
        {
            get
            {
                if (!FieldManager.FieldExists(RolesProperty))
                    Roles = Negocio.Editables.Roles.GetRoles(ID);
                return GetProperty(RolesProperty);
            }
            private set
            {
                LoadProperty(RolesProperty, value);
                OnPropertyChanged(RolesProperty);
            }
        }

        public static readonly PropertyInfo<Opciones> OpcionesProperty = RegisterProperty<Opciones>(c => c.Opciones, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
        public Opciones Opciones
        {
            get
            {
                if (!FieldManager.FieldExists(OpcionesProperty))
                {
                    Opciones = Opciones.GetOpciones(ID);
                }
                return GetProperty(OpcionesProperty);
            }
            private set
            {
                LoadProperty(OpcionesProperty, value);
                OnPropertyChanged(OpcionesProperty);
            }
        }

        public static readonly PropertyInfo<RecursosAplicacion> RecursosProperty = RegisterProperty<RecursosAplicacion>(c => c.Recursos, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
        public RecursosAplicacion Recursos
        {
            get
            {
                if (!FieldManager.FieldExists(RecursosProperty))
                {
                    Recursos = RecursosAplicacion.GetRecursosAplicacion(ID);
                }
                return GetProperty(RecursosProperty);
            }
            private set
            {
                LoadProperty(RecursosProperty, value);
                OnPropertyChanged(RecursosProperty);
            }
        }

        #endregion

        #region Factory Methods

        public static AplicacionInfo GetAplicacionInfo(Aplicaciones data)
        {
            return DataPortal.Fetch<AplicacionInfo>(data);
        }

        private AplicacionInfo()
        { /* require use of factory methods */ }

        #endregion

        #region Data Access

        private void DataPortal_Fetch(Aplicaciones criteria)
        {
            ID = criteria.IdAplicacion;
            Nombre = criteria.NombreAplicacion;
            Acronimo = criteria.Acronimo;
            switch (criteria.Tipo)
            {
                case "0":
                    Tipo = "Windows";
                    break;
                case "1":
                    Tipo = "Web";
                    break;
                case "2":
                    Tipo = "Mobile";
                    break;
                case "3":
                    Tipo = "Web Service";
                    break;
                default:
                    Tipo = "Windows Service";
                    break;
            }
            Ruta = criteria.Uri;
        }

        #endregion
    }
}
