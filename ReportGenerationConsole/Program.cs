using System;
using System.Configuration;
using System.Globalization;

namespace ReportGenerationConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            args = new string[2];
            args[0] = "20/1/2017";
            args[1] = "20/4/2018";
            if (args.Length == 0)
            {
                tt(@"
Usage: dd.exe from to
Example: dd.exe 20/1/2017 20/4/2018
");
            }
            wr("start");
            DateTime from = DateTime.Now, to = from;
            try
            {
                from = DateTime.ParseExact(args[0], "d/M/yyyy",
                                      CultureInfo.InvariantCulture);
                to = DateTime.ParseExact(args[1], "d/M/yyyy",
                                      CultureInfo.InvariantCulture);
                if (from > to)
                {
                    throw new ArgumentException("from should not be greater than to");
                }
            }catch(Exception c)
            {
                tt(c.ToString());
            }
            wr("after validation");
            var category = ConfigurationManager.AppSettings["CategoryUrl"];
            var values = ConfigurationManager.AppSettings["ValuesUrl"];
            var key = ConfigurationManager.AppSettings["Key"];
            var cat = new ApiConnector(category, values, key, from, to);
            wr("starting getting values");
            var worker = new Worker(cat);
            {
                worker.GetData();
            }
            Console.Read();
        }
        public static void tt(string k)
        {
            Console.WriteLine(k);
            Environment.Exit(0);
        }
        public static void wr(string k)
        {
            Console.WriteLine("[{0}] {1}", DateTime.Now, k);
        }
    }

}
