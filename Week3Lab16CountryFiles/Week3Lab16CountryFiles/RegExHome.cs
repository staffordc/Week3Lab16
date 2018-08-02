using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Week3Lab16CountryFiles
{
    public static class RegExHome
    {
        public static Regex FileCreationRegEx = new Regex(@"[a-z]\.[txt]", RegexOptions.IgnoreCase);
    }
}
