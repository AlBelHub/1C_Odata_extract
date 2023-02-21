using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _1C_Json_Download
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wtf = "БиблЗаписи";
            string url = $"http://10.0.0.2/LIBRARY/odata/standard.odata/Catalog_{wtf}?$format=json";

            WebClient client = new WebClient();

            client.Headers.Add(HttpRequestHeader.Authorization, "Basic " + "0JDQtNC80LjQvV/QntCfOg==");

            client.Encoding = Encoding.UTF8;
            client.BaseAddress = url;

            var json = client.DownloadString(url);

            json = json.Remove(1, 96);

            //Проблема с десериализацией вот здесь 

            var result = JsonConvert.DeserializeObject<List<Book>>(json);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
