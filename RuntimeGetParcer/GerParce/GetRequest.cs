using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace MyParcer.RuntimeGetParcer.GerParce
{
    class GetRequest : IGetRequest
    {
        HttpWebRequest Request;   
        private string _addres;
        public Dictionary<string, string> Headers { get; set; }

        public string answer { get; set; }
        public string Accept { get; set; }
        public string Host { get; set; }
        public WebProxy Proxy { get; set; }
        public string Response { get; set; }

        public GetRequest(string addres)
        {
            this._addres = addres;
            Headers = new Dictionary<string, string>();
        }
        public void getClientTimeEnter()
        {
            Request = (HttpWebRequest)WebRequest.Create(_addres);
            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            answer = reader.ReadToEnd();
        }
        public void Run()
        {
            Request = (HttpWebRequest)WebRequest.Create(_addres);
            Request.Method = "Get";
         
            Request.Proxy = Proxy;
            Request.Accept = Accept;
           // Request.Host = Host;
            foreach (var pair in Headers)
            {
                Request.Headers.Add(pair.Key, pair.Value);
            }
            try 
            {
                HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
                var stream = response.GetResponseStream();
                if(stream != null) { Response = new StreamReader(stream).ReadToEnd(); }
            }
            catch(Exception ex)
            {
                Response = ex.Message;
            }
        }
        public string GetRun()
        {
            return string.Empty;
        }
    }
}
