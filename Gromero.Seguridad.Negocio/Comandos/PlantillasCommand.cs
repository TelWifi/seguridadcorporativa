using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Gromero.Seguridad.Negocio.Comandos
{
	[Serializable]
	public class PlantillasCommand : CommandBase<PlantillasCommand>
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

		public static IEnumerable<PlantillaComplex> Execute(string _IdAplicacion, string _IdRol)
		{
			if (!CanExecuteCommand())
				throw new SecurityException("No está autorizado para ejecutar este comando!");

			PlantillasCommand cmd = new PlantillasCommand()
				{
					IdAplicacion = _IdAplicacion,
					IdRol = _IdRol
				};

			cmd.BeforeServer();
			cmd = DataPortal.Execute<PlantillasCommand>(cmd);
			cmd.AfterServer();
			return cmd.Result;
		}

		private PlantillasCommand()
		{ /* requerido por los factory methods */ }

		#endregion

		#region Client-side Code

		public static readonly PropertyInfo<List<PlantillaComplex>> ResultProperty = RegisterProperty<List<PlantillaComplex>>(p => p.Result);
		public List<PlantillaComplex> Result
		{
			get { return ReadProperty(ResultProperty); }
			set { LoadProperty(ResultProperty, value); }
		}

		public static readonly PropertyInfo<string> IdAplicacionProperty = RegisterProperty<string>(c => c.IdAplicacion);
		public string IdAplicacion
		{
			get { return ReadProperty(IdAplicacionProperty); }
			set { LoadProperty(IdAplicacionProperty, value); }
		}

		public static readonly PropertyInfo<string> IdRolProperty = RegisterProperty<string>(c => c.IdRol);
		public string IdRol
		{
			get { return ReadProperty(IdRolProperty); }
			set { LoadProperty(IdRolProperty, value); }
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
				Result = ctx.DbContext.SelectPlantillaByAppRol(IdAplicacion, IdRol).ToList();
		}

		#endregion
	}
}
