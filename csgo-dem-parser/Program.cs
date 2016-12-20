using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DemoInfo;

namespace csgo_dem_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoParser dp = new DemoParser(File.OpenRead("1.dem"));
            int mollies = 0;
            dp.ParseHeader();
            dp.FireNadeStarted += (sender, e) => {
                mollies++;
            };
            dp.ParseToEnd();
            Console.WriteLine("{0}", mollies);
        }

    }
}
