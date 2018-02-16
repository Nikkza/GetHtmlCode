using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHtmlCode
{
    public class Count
    {
        public static int CountStringOccurrences(string textToSearch, string keyword)
        {
            var count = 0;
            var i = 0;
            while ((i = textToSearch.IndexOf(keyword, i)) != -1)
            {
                i += keyword.Length;
                count++;
            }
            return count;
        }
    }
}
