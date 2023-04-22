using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace JSON_SerAndDes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var surveys = JsonSerializer.Deserialize<Surveys>(File.ReadAllText("surveys.json"));

        }
    }

}
