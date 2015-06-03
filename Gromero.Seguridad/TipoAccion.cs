namespace Gromero.Seguridad
{
	/// <summary>
	/// Tipo de Acción que se realizará para ejecutar una Opción
	/// </summary>
	public enum TipoAccion
	{
		/// <summary>
		/// Puede Agregar?
		/// </summary>
		PuedeAgregar,
		/// <summary>
		/// Puede Leer?
		/// </summary>
		PuedeLeer,
		/// <summary>
		/// Puede Actualizar?
		/// </summary>
		PuedeActualizar,
		/// <summary>
		/// Puede Eliminar?
		/// </summary>
		PuedeEliminar,
		/// <summary>
		/// Puede Agregar?
		/// </summary> 
		PuedeAgregarHijo,
		/// <summary>
		/// Puede Leer?
		/// </summary>
		PuedeLeerHijo,
		/// <summary>
		/// Puede Actualizar?
		/// </summary>
		PuedeActualizarHijo,
		/// <summary>
		/// Puede Eliminar?
		/// </summary>
		PuedeEliminarHijo,
		/// <summary>
		/// Otro permiso Adicional
		/// </summary>
		Otro
	}
}