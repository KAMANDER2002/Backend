using System;
using System.Collections.Generic;
using System.Text;

namespace MyParcer.RuntimeGetParcer.GerParce
{
    class GetRequest : IGetRequest
    {
        private string _addres;

        public GetRequest(string addres)
        {
            this._addres = addres;
        }
        public void getClientTimeEnter()
        {
            throw new NotImplementedException();
        }

        public string GetRun()
        {
            throw new NotImplementedException();
        }
    }
}
