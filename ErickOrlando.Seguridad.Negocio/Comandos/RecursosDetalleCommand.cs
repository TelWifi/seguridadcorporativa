using Csla;
using Csla.Data.EF6;
using ErickOrlando.Seguridad.Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ErickOrlando.Seguridad.Negocio.Comandos
{
	[Serializable]
	public class RecursosDetalleCommand : CommandBase<RecursosDetalleCommand>
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

		public static List<SelectRecursoDetalle_Result> Execute(string _idRecurso)
		{
			if (!CanExecuteCommand())
				throw new System.Security.SecurityException("No está autorizado para ejecutar este comando!");

			RecursosDetalleCommand cmd = new RecursosDetalleCommand { IdRecurso = _idRecurso };
			cmd.BeforeServer();
			cmd = DataPortal.Execute<RecursosDetalleCommand>(cmd);
			cmd.AfterServer();
			return cmd.Result;
		}

		private RecursosDetalleCommand()
		{ /* requerido por los factory methods */ }

		#endregion

		#region Client-side Code

		public static readonly PropertyInfo<List<SelectRecursoDetalle_Result>> ResultProperty = RegisterProperty<List<SelectRecursoDetalle_Result>>(p => p.Result);
		public List<SelectRecursoDetalle_Result> Result
		{
			get { return ReadProperty(ResultProperty); }
			set { LoadProperty(ResultProperty, value); }
		}

		public static readonly PropertyInfo<string> IdRecursoProperty = RegisterProperty<string>(c => c.IdRecurso);
		public string IdRecurso
		{
			get { return ReadProperty(IdRecursoProperty); }
			private set { LoadProperty(IdRecursoProperty, value); }
		}

		private void BeforeServer()
		{
			// TODO: Implementar codigo que cargará en el cliente
			// antes que se haga la llamada al Servidor
		}

		private void AfterServer()
		{
			// TODO: Implementar codigo que cargará en el cliente
			// despues que se haga la llamada al Servidor
		}

		#endregion

		#region Server-side Code

		protected override void DataPortal_Execute()
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
				Result = ctx.DbContext.SelectRecursoDetalleByIdRecurso(IdRecurso).ToList();
		}

		#endregion
	}
}
