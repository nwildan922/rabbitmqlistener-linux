using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQListener.RabbitMQ
{
    public static class BFIHelper
    {
        private static RestClient _client = new RestClient();
        private static string url = DataConfiguration.Configuration.ApiTransaction;
        private static Uri BaseURL = new Uri(url);

        public static void GetWorklist(string workflowId)
        {
            _client.BaseUrl = new Uri(String.Format(BaseURL + "api/WorkList/GetWorklist?workflowId=" + workflowId));
            var requests = new RestRequest(Method.GET);
            _client.Execute(requests);

        }
    }
}
