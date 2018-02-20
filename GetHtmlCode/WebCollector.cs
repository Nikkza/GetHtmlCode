using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace GetHtmlCode
{
    public class WebCollector : IWebCollector
    {
        public string Html { get; set; }

        public void GetHtmlFromUrlAsync(string url)
        {
            using (var client = new WebClient())
            {
                Html = client.DownloadString(url);

            }
        }
        
        
    }
}