//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;


namespace GR.COMEX.Framework
{
    public class UtilitarioRest
    {
        public Y DeserializarJSON<T, Y>(T request, string url, string soapAction = "", bool consultaSap = false)
        {
            var RESTProxy = new WebClient();
            if (!string.IsNullOrEmpty(soapAction))
            {
                RESTProxy.Headers["SOAPAction"] = soapAction;
            }
            RESTProxy.Headers["Content-type"] = "application/json";
            Stream stream;
            if (request.ToString() == string.Empty)
            {
                stream = RESTProxy.OpenRead(url);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                if (consultaSap)
                {
                    string jsonrpt = JsonConvert.SerializeObject(request, Formatting.None, new IsoDateTimeConverter() { DateTimeFormat = "dd.MM.yyyy" });// HH:mm:ss
                    ms = new MemoryStream(new UTF8Encoding().GetBytes(jsonrpt));
                }
                else
                {
                    var serializerToUpload = new DataContractJsonSerializer(typeof(T));
                    serializerToUpload.WriteObject(ms, request);
                }

                ms.Position = 0;
                var sr = new StreamReader(ms);
                sr.ReadToEnd();
                var dc = System.Text.Encoding.UTF8.GetString(RESTProxy.UploadData(url, "POST", ms.ToArray())).ToCharArray();
                var data = System.Text.Encoding.UTF8.GetBytes(dc);

                stream = new MemoryStream(data);
            }

            Y resultServicio;
            if (consultaSap)
            {
                StreamReader sReader = new StreamReader(stream);
                string outResult = sReader.ReadToEnd();

                resultServicio = (Y)JsonConvert.DeserializeObject(outResult, typeof(Y), new JsonSerializerSettings() { NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore });
            }
            else
            {
                var obj = new DataContractJsonSerializer(typeof(Y));
                resultServicio = (Y)obj.ReadObject(stream);
            }
            return resultServicio;
        }
    }

    public class ExtendedWebClient : WebClient
    {
        public int Timeout { get; set; }
        public ExtendedWebClient(Uri address)
        {
            Timeout = 1000;
            GetWebRequest(address);
        }
        protected override WebRequest GetWebRequest(Uri address)
        {
            var objWebRequest = base.GetWebRequest(address);
            objWebRequest.Timeout = Timeout;
            return objWebRequest;
        }
    }
}
