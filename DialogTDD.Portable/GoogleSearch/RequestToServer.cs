using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DialogTDD.Portable.GoogleSearch.DataSearch;
using DialogTDD.Portable.GoogleSearch.Interface;

namespace DialogTDD.Portable.GoogleSearch
{
    public class RequestToServer
    {
        string result;
        public string apiKey = "f3efcf782acf45419192789d612eef77";
        private IMainViewNews _view;

        public RequestToServer(IMainViewNews view)
        {
            _view = view;
            _view.btnClickSearch += _view_btnClickSearch;
        }

        private async void _view_btnClickSearch(string find)
        {
            string json = await GetNewsByUrl(find);

            BBCNews data = GetHttpAnswer(json);
            _view.UpdateData(data);

        }

        private async Task<string> GetNewsByUrl(string q)
        {
            string url = string.Format("https://newsapi.org/v2/top-headlines?sources=bbc-sport&q={0}&apiKey={1}", q, apiKey);

            using (var client = new HttpClient())
            {
                using (var r = await client.GetAsync(new Uri(url)))
                {
                    result = await r.Content.ReadAsStringAsync();
                    return result;
                }
            }
        }

        private BBCNews GetHttpAnswer(string json)
        {
            BBCNews objectBBCNews = JsonConvert.DeserializeObject<BBCNews>(result);
            return objectBBCNews;
        }







        //public async void LoadData(string q, string apiKey)
        //{
        //    HttpClient client = new HttpClient();
        //    HttpRequestMessage request = new HttpRequestMessage();
        //    request.RequestUri = new Uri("https://newsapi.org/v2/top-headlines?sources=" + q + "&apiKey=" + apiKey);
        //    request.Method = HttpMethod.Get;
        //    request.Headers.Add("Accept", "application/json");
        //    await client.SendAsync(request);
        //}
    }
}
