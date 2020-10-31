using System;
using System.Collections.Generic;
using System.Text;

namespace JSONParser {
    public class JSONParser {
        public JSON parse(string input) {
            if (input == "" || input == null) return null;

            var stack = new Stack<JSON>();
            int lastDelimiter = -1;
            for (int i = 0; i < input.Length; ++i) {
                char c = input[i];
                switch (c) {
                    case '{':
                        stack.Push(new JSONObject());

                        break;
                    case '[':
                        stack.Push(new JSONArray());
                        break;
                    case '}':
                        stack.Push(new JSONObject());

                        break;
                    case ']':
                        stack.Push(new JSONArray());
                        break;
                    case '\\':
                        if (i + 1 < input.Length) {
                            char nextChar = input[i + 1];
                            if (nextChar == '{' || nextChar == '}') {
                                ++i;
                            }
                        }
                            
                        break;
                    default:
                        break;
                }
                ++i;
            }
            return null;
        }

        protected static void addChunk(string input, int start, int end, Stack<JSON> stack) {
            if (end - start > 0) {
                var top = stack.Peek();
                if (top is JSONArray arr) {
                    
                }
            }
        }
    }
}
