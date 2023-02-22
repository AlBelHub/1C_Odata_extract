using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            var ParsedJson = JObject.Parse(json);
            JArray a = (JArray)ParsedJson["value"];

            List<Book> books = a.ToObject<List<Book>>();

            for (int i = 0;i < books.Count; i++)
            {
                Console.WriteLine
                    (
                    books[i].Code + 
                    "\n Author: " + books[i].Author + 
                    "\n Description: " + books[i].Description +
                    "\n YearOfProd: " + books[i].YearOfProd +
                    "\n AuthorZnak: " + books[i].AuthorZnak +
                    "\n Izdatel: " + books[i].Izdatel +
                    "\n IzdatelTown: " + books[i].Izdatel_Town +
                    "\n DateOfLastChanges: " + books[i].DateOfLastChanges
                    );
            }

            Console.ReadLine();
        }

    }
}
