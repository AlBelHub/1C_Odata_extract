using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
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

            JObject obj = JObject.Parse(json);

            //var SelectedFields = from field in json
            //                     where field.Equals("Code") || 
            //                     field.Equals("Description") || 
            //                     field.Equals("Автор")
            //                     select field;

            Console.WriteLine(json);





            //Console.WriteLine(client.DownloadString(url));
            Console.ReadLine();
        }
    }
}
