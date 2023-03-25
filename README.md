# GMS-regex
 Gamemaker extension for regex match, search, replace
 
 # Usages
 ## `RegexMatch(string text, string regexPattern)`
 - Return real
 - Check if `text` match by `regexPattern`.
 
 ## `RegexReplace(string text, string regexPattern, string replacement)`
 - Return string
 - Replace every matching instance of `regexPattern` with `replacement`.
 
 ## `RegexSearch(string text, string regexPattern)`
 - Return string
 - Return json-string array of all string matched. Need to be convert to array using `json_parse`
 
 ```
var res = RegexSearch("Hello world", "[e-m]+");
var js  = json_parse(res);
 ```
