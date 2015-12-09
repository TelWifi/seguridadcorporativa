using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Csla;
using ErickOrlando.Utilidades.Data;
using System.ComponentModel.DataAnnotations;
using Gromero.Seguridad.Login;

namespace Gromero.Seguridad.Entidades
{
    /// <summary>
    /// Objeto de Negocio que permite Activar el Usuario
    /// </summary>
    [Serializable]
    public class ActivarUsuario : BusinessBase<ActivarUsuario>
    {
        #region Business Methods


        /// <summary>
        /// IdProperty
        /// </summary>
        public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.ID, RelationshipTypes.PrivateField);
        private string _Id = IdProperty.DefaultValue;
        /// <summary>
        /// ID
        /// </summary>
        public string ID
        {
            get { return GetProperty(IdProperty, _Id); }
            set { SetProperty(IdProperty, ref _Id, value); }
        }
        /// <summary>
        /// NombresCompletos
        /// </summary>
        public string NombresCompletos { get; set; }

        /// <summary>
        /// NombreUsuarioProperty
        /// </summary>
        public static readonly PropertyInfo<string> NombreUsuarioProperty = RegisterProperty<string>(c => c.NombreUsuario, "Nombre de Usuario");
        /// <summary>
        /// NombreUsuario
        /// </summary>
        [Required]
        public string NombreUsuario
        {
            get { return GetProperty(NombreUsuarioProperty); }
            set { SetProperty(NombreUsuarioProperty, value); }
        }
        /// <summary>
        /// PreguntaSecretaProperty
        /// </summary>
        public static readonly PropertyInfo<string> PreguntaSecretaProperty = RegisterProperty<string>(c => c.PreguntaSecreta, "Pregunta Secreta");
        /// <summary>
        /// PreguntaSecreta
        /// </summary>
        [Required]
        public string PreguntaSecreta
        {
            get { return GetProperty(PreguntaSecretaProperty); }
            set { SetProperty(PreguntaSecretaProperty, value); }
        }
        /// <summary>
        /// RespuestaSecretaProperty
        /// </summary>
        public static readonly PropertyInfo<string> RespuestaSecretaProperty = RegisterProperty<string>(c => c.RespuestaSecreta, "Respuesta Secreta");
        /// <summary>
        /// RespuestaSecreta
        /// </summary>
        [Required]
        public string RespuestaSecreta
        {
            get { return GetProperty(RespuestaSecretaProperty); }
            set { SetProperty(RespuestaSecretaProperty, value); }
        }
        /// <summary>
        /// ClaveSecretaProperty
        /// </summary>
        public static readonly PropertyInfo<string> ClaveSecretaProperty = RegisterProperty<string>(c => c.ClaveSecreta, "Clave Secreta");
        /// <summary>
        /// ClaveSecreta
        /// </summary>
        [Required]
        public string ClaveSecreta
        {
            get { return GetProperty(ClaveSecretaProperty); }
            set { SetProperty(ClaveSecretaProperty, value); }
        }
        /// <summary>
        /// ConfirmarClaveProperty
        /// </summary>
        public static readonly PropertyInfo<string> ConfirmarClaveProperty = RegisterProperty<string>(c => c.ConfirmarClave, "Confirmar Clave");
        /// <summary>
        /// ConfirmarClave
        /// </summary>
        [Required]
        public string ConfirmarClave
        {
            get { return GetProperty(ConfirmarClaveProperty); }
            set { SetProperty(ConfirmarClaveProperty, value); }
        }

        #endregion

        #region Business Rules
        /// <summary>
        /// AddBusinessRules
        /// </summary>
        protected override void AddBusinessRules()
        {
            // TODO: agregar las reglas de validación personalizadas
            base.AddBusinessRules();

            //BusinessRules.AddRule(new Rule(IdProperty));
            BusinessRules.AddRule(new ComparaClaves(ClaveSecretaProperty, ConfirmarClaveProperty));
        }

        #endregion

        #region Factory Methods
        /// <summary>
        /// Obtiene el Objeto ActivarUsuario en base al nombre de Usuario
        /// </summary>
        public static ActivarUsuario GetActivarUsuario(FiltroUsuarios criteria)
        {
            return DataPortal.Fetch<ActivarUsuario>(criteria);
        }

        private ActivarUsuario()
        { /* Requerido para los factory methods */ }

        #endregion

        #region Data Access

        private void DataPortal_Fetch(FiltroUsuarios criteria)
        {
            using (var cn = new SqlConnection(BaseDatos.ConexionBD))
            {
                cn.Open();
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "usp_GetInfoUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", criteria.Usuario);
                    cmd.Parameters.AddWithValue("@Dominio", criteria.Dominio);
                    cmd.Parameters.AddWithValue("@Acronimo", string.Empty);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ID = dr.GetString("IdUsuario");
                            NombreUsuario = dr.GetString("CodigoUsuario");
                            NombresCompletos = dr.GetString("NombresCompletos");
                        }
                        else
                            throw new InvalidOperationException(
                                string.Format("No se encontró el usuario {0}\\{1}!", criteria.Dominio, criteria.Usuario));
                    }
                }

            }
            BusinessRules.CheckRules();
        }

        /// <summary>
        /// DataPortal_Update
        /// </summary>
        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            using (var cn = new SqlConnection(BaseDatos.ConexionBD))
            {
                cn.Open();
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "usp_ActivaUsuario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    DoInsertUpdate(cmd);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DoInsertUpdate(SqlCommand cmd)
        {
            using (BypassPropertyChecks)
            {
                cmd.Parameters.AddWithValue("@IdUsuario", ID);
                cmd.Parameters.AddWithValue("@IdClave", Guid.NewGuid().ToString());
                var cryptocon = new SimpleInteroperableEncryption();
                cmd.Parameters.AddWithValue("@Clave", cryptocon.Encrypt(ClaveSecreta));
                cmd.Parameters.AddWithValue("@PreguntaSecreta", PreguntaSecreta);
                cmd.Parameters.AddWithValue("@RespuestaSecreta", cryptocon.Encrypt(RespuestaSecreta));
            }
        }

        #endregion
    }
}
