using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetHtmlCode
{
    public interface IWebCollector
    {
        /// <summary>
        /// Returns html code for given string
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        void GetHtmlFromUrlAsync(string url);
        string Html { get; set; }
    }
}
