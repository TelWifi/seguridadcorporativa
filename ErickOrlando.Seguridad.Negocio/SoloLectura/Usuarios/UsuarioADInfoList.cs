using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GRomeroAD.DirectoryServices;
using System.Collections.ObjectModel;
using ErickOrlando.Utilidades.Data;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
	public class UsuarioADInfoList : ObservableCollection<Directorio>
	{
		private UsuarioADInfoList()
		{
			
		}

		public class FiltroAD : FiltroCriteria
		{
			public string Dominio { get; set; }
		}

		public static UsuarioADInfoList GetUsuarioADInfoList(FiltroAD filtro)
		{
			var obj = new UsuarioADInfoList();
			var credenciales = new WinCredentials(filtro.Dominio);
			credenciales.FormateaDominio();
			//Invocamos la función que nos permite acceder a la información del AD actual
			foreach (var item in GRomeroDirectory.GetPersonsInDirectory(filtro.ValorBusqueda, credenciales))
				obj.Add(item);

			return obj;
		}
	}
}
