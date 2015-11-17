using Gromero.Seguridad.Datos;
using SeguridadGRomero.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace SeguridadGRomero
{
    public class SeguridadGR : ISeguridadGR
    {
        private const string IdUsuarioTemp = "00c300a1-b14a-44a6-920b-ade75c9e8b6f";

        public bool CambiarClave(RequestCambioClave request)
        {
            if (request.IdUsuario == IdUsuarioTemp)
            {
                //Se cambia la clave
                return true;
            }
            else
                return false;
        }

        public ResponseLoginUsuario Login(RequestLogin request)
        {
            if (request.CodigoUsuario == "evelascom"
                && request.Clave == "erickorlando"
                && request.Dominio == "TRAMARSA")
            {
                var respuesta = new ResponseLoginUsuario
                {
                    IdUsuario = IdUsuarioTemp,
                    ResultadoLogin = true
                };
                return respuesta;
            }
            else
                return new ResponseLoginUsuario();
        }

        public ResponseInfoUsuarioDTO GetInfoUsuario(RequestInfoUsuario request)
        {
            ResponseInfoUsuarioDTO result = new ResponseInfoUsuarioDTO();
            if (String.IsNullOrEmpty(request.IdUsuario))
                return result;

            using (var contexto = new GROMEROEntities())
            {
                var query = contexto.SelectUsuario(request.IdUsuario);

                //Aunque haya un sólo registro igual hacemos el recorrido
                foreach (var item in query)
                {
                    result.IdUsuario = item.IdUsuario;
                    result.CodigoUsuario = item.CodigoUsuario;
                    result.NombresCompletos = string.Format("{0} {1} {2}",
                                            item.Nombres, item.ApellidoPaterno, item.ApellidoMaterno);
                    result.Dominio = item.Dominio;
                    result.Correo = item.Correo;
                }
            }
            return result;
        }

        public bool CerrarSesion(string IdUsuario)
        {
            return true;
        }

        public bool ConsultarPermisos(RequestConsultaPermiso request)
        {
            return true;
        }

        public IEnumerable<ResponseListaUsuarios> ListarUsuarios(RequestListarUsuario request)
        {
            request.DNI = request.DNI ?? string.Empty;
            request.Nombres = request.Nombres ?? string.Empty;
            request.CodigoUsuario = request.CodigoUsuario ?? string.Empty;

            using (var contexto = new GROMEROEntities())
            {
                var resultado = new List<ResponseListaUsuarios>();
                var query = contexto.SelectUsuarioByCodigo(request.CodigoUsuario).AsEnumerable();
                query = query.Where(q => q.DNI.Contains(request.DNI) || q.Nombres.Contains(request.Nombres));
                foreach (var item in query)
                {
                    resultado.Add(new ResponseListaUsuarios { IdUsuario = item.IdUsuario, CodigoUsuario = item.CodigoUsuario, DNI = item.DNI, NombresCompletos = string.Format("{0} {1} {2}", item.Nombres, item.ApellidoPaterno, item.ApellidoMaterno) });
                }
                return resultado;
            }
        }

        public IEnumerable<ResponseUsuarioCargo> ListarUsuariosPorCargo(string CodigoCargo)
        {
            var xDoc = new XmlDocument();
            xDoc.Load("/Usuarios.xml");
            var Usuarios = xDoc.GetElementsByTagName("Usuarios");
            var lista = ((XmlElement)Usuarios[0]).GetElementsByTagName("Usuario");

            var resultado = new List<ResponseUsuarioCargo>();
            foreach (XmlElement item in lista)
            {
                if (item.GetAttribute("CodigoCargo") == CodigoCargo)
                    resultado.Add(new ResponseUsuarioCargo
                        {
                            IdUsuario = item.GetAttribute("IdUsuario"),
                            CodigoUsuario = item.GetAttribute("CodigoUsuario"),
                            NombresCompletos = item.GetAttribute("NombresCompletos")
                        });
            }
            return resultado;
        }
    }
}
