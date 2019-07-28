using RestSharp;
using System.Collections.Generic;

namespace Five9
{
    class Program
    {
        // How to use Web2Campaign AddToList for Five9
        static void Main(string[] args)
        {
            var program = new Program();
            var restClient = new RestClient("https://api.five9.com/web2campaign/AddToList");
            var five9Record = program.GetFive9Record();

            var request = new RestRequest(Method.GET);
            foreach (var kvp in five9Record)
            {
                request.AddQueryParameter(kvp.Key, kvp.Value);
            }

            var response = restClient.Execute(request);
        }

        public IDictionary<string, string> GetFive9Record()
        {
            var result = new Dictionary<string, string>();
            result.Add("F9domain", "{F9domain}");
            result.Add("F9list", "{five9list}");
            result.Add("F9key", "{five9key}");
            result.Add("F9updateCRM", "{F9updateCRM}");
            result.Add("number1", "{number1}");
            result.Add("first_name", "{first_name}");
            result.Add("last_name", "{last_name}");
            result.Add("ANI", "{ANI}");
            result.Add("LeadID", "{LeadID}");
            result.Add("Client ID", "{Client ID}");
            result.Add("ActivityDestination", "{ActivityDestination}");
            result.Add("F9CallASAP", "{F9CallASAP}");

            return result;
        }
    }
}
