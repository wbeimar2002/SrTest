//####################################################################
// ASSEMBLY:        SrTest.Tools
// AUTOR:           Alexander Gonzalez 
// DESCRIPTION:     Initial Arquitecture application 
// DATE:            01/16/2019
//####################################################################
namespace SrTest.Tools.Support
{
    using System;
    using System.Configuration;
    using System.Net;

    public static class HttpTools
    {
        /// <summary>
        ///  Method to prepare HTTP requests that will consume the Rest services
        /// </summary>
        /// <param name="UrlService">URL of the service to be called</param>
        /// <param name="Verb"> Verb that is going to use Get, Post ETC ...</param>
        /// <returns>Return Object HttpWebRequest prepare for use </returns>
        public static HttpWebRequest PrepareHttpRequest(string serviceUrl, string Verb)
        {
            HttpWebRequest HttpwebRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);
            HttpwebRequest.KeepAlive = false;
            //HttpwebRequest.Timeout = Convert.ToInt32(ConfigurationManager.AppSettings.Get("Bisap:TimeOutSap"));
            //HttpwebRequest.Credentials = new NetworkCredential(ConfigurationManager.AppSettings.Get("UsuarioSAP"),
            //                                                    ConfigurationManager.AppSettings.Get("ClaveSAP"));

            HttpwebRequest.Method = Verb;
            HttpwebRequest.ContentType = ContentTypesHelper.ApplicationJson;

            return HttpwebRequest;
        }
    }
}
