using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JSON_SerAndDes
{
    internal class Answer : IAnswers
    {
        public string Text { get; set; }
        public IAnswers ConstructWithJsonText(string jsonText)
        {
            var ret = new Answer();
            ret.Text = JsonSerializer.Deserialize<string>(jsonText);
            return ret;
        }
    }
}
