using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csla;
using Csla.Data;
using Gromero.Seguridad.Datos;
using Csla.Data.EF6;

namespace Gromero.Seguridad.Negocio.Comandos
{
    [Serializable]
    public class PerfilUsuarioCommand : CommandBase<PerfilUsuarioCommand>
    {
        #region Authorization Methods

        public static bool CanExecuteCommand()
        {
            // TODO: Personalizar para chequear reglas de autorización
            //return Csla.ApplicationContext.User.IsInRole("Role");
            return true;
        }

        #endregion

        #region Factory Methods

        public static string Execute(string idUsuario, string idAplicacion)
        {
            PerfilUsuarioCommand cmd = new PerfilUsuarioCommand
                {
                    IdUsuario = idUsuario,
                    IdAplicacion = idAplicacion
                };
            cmd.BeforeServer();
            cmd = DataPortal.Execute<PerfilUsuarioCommand>(cmd);
            cmd.AfterServer();
            return cmd.Result;
        }

        private PerfilUsuarioCommand()
        { /* requerido por los factory methods */ }

        #endregion

        #region Client-side Code

        public static readonly PropertyInfo<string> ResultProperty = RegisterProperty<string>(p => p.Result);
        public string Result
        {
            get { return ReadProperty(ResultProperty); }
            set { LoadProperty(ResultProperty, value); }
        }

        public string IdAplicacion { get; set; }
        public string IdUsuario { get; set; }

        private void BeforeServer()
        {
            // Implementar codigo que cargará en el cliente
            // antes que se haga la llamada al Servidor
        }

        private void AfterServer()
        {
            // Implementar codigo que cargará en el cliente
            // despues que se haga la llamada al Servidor
        }

        #endregion

        #region Server-side Code

        protected override void DataPortal_Execute()
        {
            using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
            {
                var consulta = ctx.DbContext.GetIdPerfilUsuario(IdUsuario, IdAplicacion);
                
                Result = consulta.FirstOrDefault();
            }
        }

        #endregion
    }
}
