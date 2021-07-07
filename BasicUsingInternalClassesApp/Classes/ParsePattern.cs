using System;
using System.Collections.Generic;
using static System.Console;

namespace BasicUsingInternalClassesApp.Classes
{
    public class ParsePattern
    {

        /// <summary>
        /// Get all parameter names and their values
        /// </summary>
        public static void DecodeAllParameters()
        {
            const string webAddress = "https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world?p=toplevel&lang=english";
            Dictionary<string, string> dictionary = new Uri(webAddress).GetQueryParameters();

            foreach (var (key, value) in dictionary)
            {
                WriteLine($"{key} = {value}");
            }
        }
        
    }
}
