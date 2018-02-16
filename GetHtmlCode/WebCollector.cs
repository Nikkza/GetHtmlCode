using System.Net.Http;
using System.Threading.Tasks;


namespace GetHtmlCode
{
    public class WebCollector : IWebCollector
    {
        public async Task<string> GetHtmlFromUrlAsync(string url)
        {
            using (var http = new HttpClient())
            {
                var response = await http.GetAsync(url);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
