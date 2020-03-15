using AngleSharp;
using CsQuery;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlmatyKSKForms
{
    class HttpController
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<StatusResponsePair> LoginAsync(string bin,string SecretFrase)
        {
            var values = new Dictionary<string, string>
                {
                { "BIN", bin },
                { "SecretFrase", SecretFrase }
            };

            var content = new FormUrlEncodedContent(values);
            await client.PostAsync("https://almaty-ksk.kz/account/login", content);
            var t = await client.GetAsync("https://almaty-ksk.kz/api/houseadministration?skip=0&take=20&filter=&sort=Id%7Cfalse");
            return await UserInfo();
        }
        public static async Task<StatusResponsePair> UserInfo()
        {
            var response = await client.PostAsync("https://almaty-ksk.kz/api/UserProfile/myprofile", null);

            return new StatusResponsePair(response.StatusCode,
                response.Content.ReadAsStringAsync().Result);
        }
        public static async Task<Dictionary<string, string>> ParseUserInfoResponseAsync(string response)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var config = Configuration.Default;
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(req => req.Content(response));
            var tr = document.QuerySelectorAll("tr");
            foreach(var td in tr)
            {
                var data = td.QuerySelectorAll("td").ToArray();
                dic.Add(data[0].TextContent, data[1].TextContent);
            }
            return dic;
        }
        public async Task<StatusResponsePair> CreateReport(int Kind,
            int CondominiumId,string PeriodFrom,string PeriodTo, string AnualPeriod)
        {
            var values = new Dictionary<string, string>
            {
                {"AnualPeriod",AnualPeriod },
                { "Kind", Kind.ToString() },
                { "CondominiumId", CondominiumId.ToString() },
                {"PeriodFrom",PeriodFrom },
                {"PeriodTo",PeriodTo }
            };

            var content = new FormUrlEncodedContent(values);
            
            var response = await client.PostAsync("https://almaty-ksk.kz/api/reporting", content);
            var s = response.Content.ReadAsStringAsync();
            return new StatusResponsePair(response.StatusCode, 
                response.Content.ReadAsStringAsync().Result);
        }
        public async Task<StatusResponsePair> EditReport(string reportId, Dictionary<string, string> values)
        {
            var content = new FormUrlEncodedContent(values);

            var response = await client.PutAsync("https://almaty-ksk.kz/api/reporting/general/"+reportId+"/ca", content);

            return new StatusResponsePair(response.StatusCode,
                response.Content.ReadAsStringAsync().Result);
        }
        public static async Task<StatusResponsePair> GetHandbook()
        {
            var response = await client.GetAsync("https://almaty-ksk.kz/api/condominium/handbook");
            return new StatusResponsePair(response.StatusCode,
                await response.Content.ReadAsStringAsync());
        
        }
        public static async Task<Dictionary<string,StatusResponsePair>> UploadReport(Report house,Period p)
        {
            Dictionary<string, StatusResponsePair> d = new Dictionary<string, StatusResponsePair>();
            var handBook = await HttpController.GetHandbook();

            Dictionary<string, int> housesDic = new Dictionary<string, int>();
            var definition = new[]
            {
                new{
                Name = "",
                Id=-1
                }

            }.ToList();

            var houses = JsonConvert.DeserializeAnonymousType(handBook.response, definition);

            HttpController http = new HttpController();
            var result = await http.CreateReport(0, houses.Where(a => a.Name == house.House).FirstOrDefault().Id, p.From, p.To,p.AnualPeriod);
            d.Add("create", result);
            if (result.code == System.Net.HttpStatusCode.OK)
            {
                Dictionary<string, string> values = new Dictionary<string, string>();
                foreach(var e in house.Data)
                {
                    values.Add(e.Key.ValueName.RequestName, Math.Round( e.Value).ToString());
                }
                foreach (var e in house.TextData)
                {
                    values.Add(e.Key.ValueName.RequestName, e.Value);
                }
                var response = JsonConvert.DeserializeObject<Dictionary<string, string>>(result.response);

                var t = await http.EditReport(response["Id"], values);
                d.Add("edit", t);
            }
            return d;
        }
    }
}
