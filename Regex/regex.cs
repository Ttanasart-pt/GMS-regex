using RGiesecke.DllExport;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace GameMakerRegexExtension {
    public class RegexHelper {
        [DllExport("RegexMatch", CallingConvention.Cdecl)]
        public static double RegexMatch(string input, string pattern) {
            try {
                return Regex.IsMatch(input, pattern)? 1 : 0;
            } catch (ArgumentException) {
                return 0;
            }
        }

        [DllExport("RegexReplace", CallingConvention.Cdecl)]
        public static string RegexReplace(string input, string pattern, string replacement) {
            try {
                return Regex.Replace(input, pattern, replacement);
            } catch (ArgumentException) {
                return input;
            }
        }

        
        [DllExport("RegexSearch", CallingConvention.Cdecl)]
        public static string RegexSearch(string input, string pattern) {
            try {
                MatchCollection matches = Regex.Matches(input, pattern);
                string jsonString = "[";
                
                for (int i = 0; i < matches.Count; i++)
                    jsonString += (i > 0? "," : "") + "\"" + matches[i].Value + "\"";

                return jsonString + "]";
            } catch (ArgumentException) {
                return "[]";
            }
        }
    }
}
