
namespace Gromero.Seguridad.Datos
{
	public partial class GROMEROEntities
	{
		public GROMEROEntities(string dataBase)
			: base(string.Format("name={0}", dataBase))
		{

		}
	}
}
