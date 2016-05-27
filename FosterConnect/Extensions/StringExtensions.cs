using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FosterConnect
{
    public static class StringExtensions
    {
        public static bool HasValue(this string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public static string NewlinesToHtml(this string input)
        {
            return input.Replace("\r\n", "<br/>").Replace("\n", "<br/>").Replace("\r", "<br/>");
        }
    }
}