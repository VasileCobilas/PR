using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerationConsole
{
    class ApiConnector
    {
        public HttpClient httpClient;
        private string category;
        private string values;
        private DateTime from;
        private DateTime to;
        private string key;

        public ApiConnector(string category, string values, string key, DateTime from, DateTime to)
        {
            this.category = category;
            this.values = values;
            this.from = from;
            this.to = to;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/csv"));
            httpClient.DefaultRequestHeaders.Add("X-API-Key", key);
        }

        public IEnumerable<Category> GetCategories()
        {
            var task = httpClient.GetAsync(category).GetAwaiter().GetResult();
            string v = task.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var o = Read<Category>(v);

            return o;
        }
        public IEnumerable<Order> GetValues()
        {
            var url = values +
                "?start=" +
                from.ToString("yyyy-M-dd") +
                "&end=" + to.ToString("yyyy-M-dd");

            var task = httpClient.GetAsync(url).GetAwaiter().GetResult();
            string v = task.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var o = Read<Order>(v);

            return o;
        }
        public IEnumerable<T> Read<T>(string v) where T : class
        {
            var csv = new CsvReader(new StringReader(v));
            var ct = new List<T>();
            csv.Read();
            csv.ReadHeader();
            while (csv.Read())
            {
                var record = csv.GetRecord<T>();
                ct.Add(record);
            }
            return ct;
        }
    }
}
