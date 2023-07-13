using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTOtesting.Utilities
{
    public class jsonReader
    {
        public jsonReader()
        { 

        }

        public string extractData(String tokenName)
        {
            String JsonString = File.ReadAllText("Utilities/testData.json");
            var jsonObject = JToken.Parse(JsonString);

            return jsonObject.SelectToken(tokenName).Value<string>();
        }
    }
}
