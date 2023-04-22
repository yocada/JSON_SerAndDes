using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JSON_SerAndDes
{
    internal class AnswersOnSituations : IAnswers
    {
        public IList<string> Situations { get; set; }
        public IList<string> Actions { get; set; }

        public IAnswers ConstructWithJsonText(string jsonText)
        {
            var list = (IList<AnswersOnSituations>)JsonSerializer.Deserialize(jsonText, typeof(IList<AnswersOnSituations>));
            return list[0];
        }
    }
}
