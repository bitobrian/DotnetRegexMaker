using System;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexMaker.Ssr.Data
{
    public static class RegexBuilder
    {
        public static string ToRegex(string[] valueArray, string currentRegex)
        {
            var finalRegex = new StringBuilder(currentRegex);

            //1st Section
            switch (valueArray[0])
            {
                case "Starts With":
                    if (currentRegex != "")
                        break;
                    finalRegex.Append(@"(?<!(.))");
                    break;
            }

            //2nd Section
            switch (valueArray[1])
            {
                case "Any Character":
                    finalRegex.Append(@".");
                    break;
                case "Any Integer":
                    finalRegex.Append(@"[0-9]");
                    break;
                case "Any Letter":
                    finalRegex.Append(@"[a-zA-Z]");
                    break;
                case "Any Lower Cased Letter":
                    finalRegex.Append(@"[a-z]");
                    break;
                case "Any Upper Cased Letter":
                    finalRegex.Append(@"[A-Z]");
                    break;
                case "Any Alphanumeric":
                    finalRegex.Append(@"[0-9a-zA-Z]");
                    break;
                case "String":
                    finalRegex.Append(valueArray[2].Contains('.') ? @"\." : valueArray[2]);
                    break;
                case "Specify":
                    finalRegex.Append(valueArray[2].Contains('.') ? @"\." : valueArray[2]);
                    break;
            }

            if (valueArray[1].Equals("String"))
            {
                return finalRegex.ToString();
            }
            
            switch (valueArray[3])
            {
                case "Once":
                    finalRegex.Append(@"{1}");
                    break;
                case "One or More":
                    finalRegex.Append(@"{1,}");
                    break;
                case "Between..":
                    finalRegex.Append(@"{"+valueArray[4]+","+valueArray[5]+"}");
                    break;
            }
            
            return finalRegex.ToString();
        }
        
        public static string ToFinalRegex(string regex)
        {
            var capRegex = @"(?!.)";

            var currentRegex = new StringBuilder(regex);

            if(!regex.Contains(capRegex))
                currentRegex.Append(capRegex);           

            return currentRegex.ToString();
        }
        
        public static bool CheckRegex(string inputValue, string regexValue)
        {
            var matchSuccess = false;

            try
            {
                var regex1 = new Regex(regexValue);
                var match = regex1.Match(inputValue);

                if (match.Success)
                    matchSuccess = true;
            }
            catch
            {
            }


            return matchSuccess;
        }
    }
}