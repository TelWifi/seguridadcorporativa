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
    /// Objeto de Negocio que permite Cambiar la Clave del Usuario
    /// </summary>
    [Serializable]
    public class CambiarClave : BusinessBase<CambiarClave>
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
        /// UsuarioProperty
        /// </summary>
        public static readonly PropertyInfo<string> UsuarioProperty = RegisterProperty<string>(c => c.Usuario);
        /// <summary>
        /// Nombre de Usuario
        /// </summary>
        [Required]
        public string Usuario
        {
            get { return GetProperty(UsuarioProperty); }
            set { SetProperty(UsuarioProperty, value); }
        }
        /// <summary>
        /// NombresCompletos
        /// </summary>
        public string NombresCompletos { get; set; }
        /// <summary>
        /// PreguntaSecreta
        /// </summary>
        public string PreguntaSecreta { get; set; }
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
        /// SecretAnswerProperty
        /// </summary>
        public static readonly PropertyInfo<string> SecretAnswerProperty = RegisterProperty<string>(c => c.SecretAnswer);
        /// <summary>
        /// SecretAnswer
        /// </summary>
        public string SecretAnswer
        {
            get { return GetProperty(SecretAnswerProperty); }
            set { SetProperty(SecretAnswerProperty, value); }
        }
        /// <summary>
        /// ClaveNuevaProperty
        /// </summary>
        public static readonly PropertyInfo<string> ClaveNuevaProperty = RegisterProperty<string>(c => c.ClaveNueva, "Clave Nueva");
        /// <summary>
        /// ConfirmarClave
        /// </summary>
        [Required]
        public string ClaveNueva
        {
            get { return GetProperty(ClaveNuevaProperty); }
            set { SetProperty(ClaveNuevaProperty, value); }
        }
        /// <summary>
        /// ConfirmarClaveProperty
        /// </summary>
        public static readonly PropertyInfo<string> ConfirmarClaveProperty = RegisterProperty<string>(c => c.ConfirmarClave, "Confirmar Clave");
        /// <summary>
        /// ConfirmarClave
        /// </summary>
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

            BusinessRules.AddRule(new ComparaClaves(ClaveNuevaProperty, ConfirmarClaveProperty));
        }

        #endregion

        #region Factory Methods
        /// <summary>
        /// Obtiene el Objeto CambiarClave en base al Código del Usuario
        /// </summary>
        public static CambiarClave GetCambiarClave(FiltroUsuarios criteria)
        {
            return DataPortal.Fetch<CambiarClave>(criteria);
        }

        private CambiarClave()
        { /* Requerido para los factory methods */ }
        /// <summary>
        /// Guarda los Cambios
        /// </summary>
        public new CambiarClave Save()
        {
            if (GRCrypto.Encriptar(RespuestaSecreta) != SecretAnswer)
                throw new InvalidOperationException("La respuesta secreta no coincide!");
            return base.Save();
        }

        #endregion

        #region Data Access

        private void DataPortal_Fetch(FiltroUsuarios criteria)
        {
            using (var cn = new SqlConnection(BaseDatos.ConexionBD))
            {
                cn.Open();
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "usp_UsuarioSelectByChangePass";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", criteria.Usuario);
                    cmd.Parameters.AddWithValue("@Dominio", criteria.Dominio);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ID = dr.GetString("IdUsuario");
                            Usuario = dr.GetString("CodigoUsuario");
                            NombresCompletos = string.Format("{0} {1} {2}",
                                dr.GetString("Nombres"),
                                dr.GetString("ApellidoPaterno"),
                                dr.GetString("ApellidoMaterno"));
                            PreguntaSecreta = dr.GetString("PreguntaSecreta");
                            SecretAnswer = dr.GetString("RespuestaSecreta");
                            //if (dr.GetString("Tipo") == "I")
                            //    throw new InvalidOperationException("Sólo los usuarios externos pueden cambiar su clave!");
                        }
                        else
                            throw new InvalidOperationException(
                                string.Format("No se encontró el usuario {0}\\{1} como Externo!", 
                                criteria.Dominio,
                                criteria.Usuario));
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
                cmd.Parameters.AddWithValue("@Clave", GRCrypto.Encriptar(ClaveNueva));
                cmd.Parameters.AddWithValue("@PreguntaSecreta", PreguntaSecreta);
                cmd.Parameters.AddWithValue("@RespuestaSecreta", GRCrypto.Encriptar(RespuestaSecreta));
            }
        }

        #endregion
    }
}
