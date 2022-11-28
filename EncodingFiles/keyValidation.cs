using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EncodingFiles
{
    internal class keyValidation
    {
        public static bool Validate(string key)
        {
            Regex rg = new Regex("([^ -~])");
            bool IsValid = !rg.IsMatch(key) && (key.Length == 16 || key.Length == 24 || key.Length == 32);
            return IsValid;
        }
    }
}
