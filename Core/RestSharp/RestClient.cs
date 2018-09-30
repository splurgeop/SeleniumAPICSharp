using Core.Enums;
using RestSharp;
using System.Collections.Generic;

namespace Core.RestSharp
{
    public class RestClient
    {        
        public  void request(string url,object body, Dictionary<string, string> queryStringParameters = null, Dictionary<string, string> headers = null, Method type=Method.POST,ContentType contentType = ContentType.Json,int timeOut=1000)
        {            
            RestClient client = new RestClient();            
            RestRequest request = new RestRequest(url, type) { Timeout = timeOut };
            
        }
        


    }
}
