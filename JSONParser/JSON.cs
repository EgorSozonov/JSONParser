using System;
using System.Collections.Generic;
using System.Text;

namespace JSONParser {
    public class JSON {
    }

    public sealed class JSONString : JSON {
        public string val;
    }

    public sealed class JSONNumber : JSON {
        public double val;
    }

    public sealed class JSONObject : JSON {
        public Dictionary<string, JSON> dict = new Dictionary<string, JSON>();               
    }

    public sealed class JSONArray : JSON {
        public List<JSONObject> arr;
    }
}
