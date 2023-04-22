using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JSON_SerAndDes
{
    internal class Survey
    {
        public string Question { get; set; }

        [JsonConverter(typeof(AnswersConverter))]
        public IAnswers Answers { get; set; }
    }



    internal class AnswersConverter : JsonConverter<IAnswers>
    {
        public override IAnswers Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var ret = new Answer();
                return ret.ConstructWithJsonText(JsonObject.Parse(ref reader).ToJsonString());
            }
            else
            {
                var ret = new AnswersOnSituations();
                return ret.ConstructWithJsonText(JsonObject.Parse(ref reader).ToJsonString());
            }
        }

        public override void Write(Utf8JsonWriter writer, IAnswers value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
