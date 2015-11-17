using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Security;

namespace Gromero.Seguridad.Login
{
	/// <summary>
	/// MemberShipProvider de Seguridad COMEX para ASP.NET
	/// </summary>
	public class GromeroMembershipProvider : MembershipProvider
	{

		private string _ApplicationName;
		/// <summary>
		/// Nombre de la Aplicación
		/// </summary>
		public override string ApplicationName
		{
			get
			{
				return _ApplicationName;
			}
			set
			{
				_ApplicationName = value;
			}
		}

		#region Metodos no Implementados

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="oldPassword"></param>
		/// <param name="newPassword"></param>
		/// <returns></returns>
		public override bool ChangePassword(string username, string oldPassword, string newPassword)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="newPasswordQuestion"></param>
		/// <param name="newPasswordAnswer"></param>
		/// <returns></returns>
		public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="email"></param>
		/// <param name="passwordQuestion"></param>
		/// <param name="passwordAnswer"></param>
		/// <param name="isApproved"></param>
		/// <param name="providerUserKey"></param>
		/// <param name="status"></param>
		/// <returns></returns>
		public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="deleteAllRelatedData"></param>
		/// <returns></returns>
		public override bool DeleteUser(string username, bool deleteAllRelatedData)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		public override bool EnablePasswordReset
		{
			get { return true; }
		}

		/// <summary>
		/// 
		/// </summary>
		public override bool EnablePasswordRetrieval
		{
			get { return false; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="emailToMatch"></param>
		/// <param name="pageIndex"></param>
		/// <param name="pageSize"></param>
		/// <param name="totalRecords"></param>
		/// <returns></returns>
		public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="usernameToMatch"></param>
		/// <param name="pageIndex"></param>
		/// <param name="pageSize"></param>
		/// <param name="totalRecords"></param>
		/// <returns></returns>
		public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pageIndex"></param>
		/// <param name="pageSize"></param>
		/// <param name="totalRecords"></param>
		/// <returns></returns>
		public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override int GetNumberOfUsersOnline()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="answer"></param>
		/// <returns></returns>
		public override string GetPassword(string username, string answer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="userIsOnline"></param>
		/// <returns></returns>
		public override MembershipUser GetUser(string username, bool userIsOnline)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="providerUserKey"></param>
		/// <param name="userIsOnline"></param>
		/// <returns></returns>
		public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="email"></param>
		/// <returns></returns>
		public override string GetUserNameByEmail(string email)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		public override int MaxInvalidPasswordAttempts
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// 
		/// </summary>
		public override int MinRequiredNonAlphanumericCharacters
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// 
		/// </summary>
		public override int MinRequiredPasswordLength
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// 
		/// </summary>
		public override int PasswordAttemptWindow
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// 
		/// </summary>
		public override MembershipPasswordFormat PasswordFormat
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// 
		/// </summary>
		public override string PasswordStrengthRegularExpression
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// 
		/// </summary>
		public override bool RequiresQuestionAndAnswer
		{
			get { throw new NotImplementedException(); }
		}
		/// <summary>
		/// 
		/// </summary>
		public override bool RequiresUniqueEmail
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="answer"></param>
		/// <returns></returns>
		public override string ResetPassword(string username, string answer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userName"></param>
		/// <returns></returns>
		public override bool UnlockUser(string userName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="user"></param>
		public override void UpdateUser(MembershipUser user)
		{
			throw new NotImplementedException();
		}

		#endregion


		/// <summary>
		/// Comprobación del Usuario
		/// </summary>
		/// <param name="username">Usuario</param>
		/// <param name="password">Contrasena</param>
		/// <returns>Booleano</returns>
		public override bool ValidateUser(string username, string password)
		{
			var result = false;

			//Comprobamos que el Nombre de Usuario contiene un Dominio
			var infoUser = Publicos.ComprobarDominioEnUsuario(username);

			//Comprobamos primero el tipo de Usuario
			if (GRPrincipal.Load(infoUser.Usuario, infoUser.Dominio))
			{
				if (InfoUsuario.Instancia.Tipo)
					result = GRPrincipal.Login(infoUser.Usuario, password, infoUser.Dominio);
				else
					result = GRPrincipal.Login(infoUser.Usuario, GRCrypto.Encriptar(password));
			}

			return result;
		}

		/// <summary>
		/// Inicializa una nueva instancia de GromeroMembershipProvider
		/// </summary>
		public GromeroMembershipProvider()
		{
			_ApplicationName = "Aplicación Corporativa de Seguridad ©";
		}
	}
}
