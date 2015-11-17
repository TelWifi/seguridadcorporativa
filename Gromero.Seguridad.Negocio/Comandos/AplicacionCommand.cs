using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Gromero.Seguridad.Negocio.SoloLectura;
using ErickOrlando.Utilidades.Data;

namespace Gromero.Seguridad.Negocio.Comandos
{
	[Serializable]
	public class AplicacionCommand : CommandBase<AplicacionCommand>
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

		public static AplicacionInfo Execute(string name)
		{
			if (!CanExecuteCommand())
				throw new System.Security.SecurityException("No está autorizado para ejecutar este comando!");

			AplicacionCommand cmd = new AplicacionCommand() { NombreApp = name };
			cmd.BeforeServer();
			cmd = DataPortal.Execute<AplicacionCommand>(cmd);
			cmd.AfterServer();
			return cmd.Result;
		}

		private AplicacionCommand()
		{ /* requerido por los factory methods */ }

		#endregion

		#region Client-side Code

		public static readonly PropertyInfo<AplicacionInfo> ResultProperty = RegisterProperty<AplicacionInfo>(p => p.Result);
		public AplicacionInfo Result
		{
			get { return ReadProperty(ResultProperty); }
			set { LoadProperty(ResultProperty, value); }
		}

		public string NombreApp { get; set; }

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
			// TODO: Implementar codigo que cargará en el servidor
			// y establece el resultado
			// TODO: Implementar codigo que cargará en el servidor
			// y establece el resultado
			var lista = AplicacionInfoList.GetAplicacionInfoList(new FiltroCriteria
			{
				NombreCampo = "Nombre",
				ValorBusqueda = NombreApp
			});

			Result = lista.FirstOrDefault();
		}

		#endregion


	}
}
