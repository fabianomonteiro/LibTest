using RestSharp;
using System;
using System.Net.Http;

namespace LibMultiTargetTest
{
    public class Class1
    {
        public void Teste()
        {
            var httpCLient = new HttpClient();
            var newtonsoft = new Newtonsoft.Json.JsonSerializer();
            var restClient = new RestClient();
        }
    }
}
