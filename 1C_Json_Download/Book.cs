using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _1C_Json_Download
{
    public class Book
    {
        [JsonProperty("Code")]
        public string Code { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("Автор")]
        public string Author { get; set; }
        [JsonProperty("АвторскийЗнак")]
        public string AuthorZnak { get; set; }
        [JsonProperty("ГодИздания")]
        public string YearOfProd { get; set; }
        [JsonProperty("ДатаСозданияЗаписи")]
        public string DateOfCreate { get; set; }
        [JsonProperty("ИздательствоПредставление")]
        public string Izdatel { get; set; }
        [JsonProperty("МестоИзданияПредставление")]
        public string Izdatel_Town { get; set; }
    }
}
