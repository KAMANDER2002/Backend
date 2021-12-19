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
        WebRequest Request;   
        private string _addres;
        public string answer { get; set; }

        public GetRequest(string addres)
        {
            this._addres = addres;
        }
        public void getClientTimeEnter()
        {
             Request = (HttpWebRequest)WebRequest.Create(_addres);
            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            answer = reader.ReadToEnd();
        }

        public string GetRun()
        {
            throw new NotImplementedException();
        }
    }
}
