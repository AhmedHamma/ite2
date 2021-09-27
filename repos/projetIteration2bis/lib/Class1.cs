using Newtonsoft.Json;
using projetIteration2bis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Class1
    {
        public async void getFromLocation(Action<List<Root>> a)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://data.mobilites-m.fr/api/linesNear/json?x=5.709360123&y=45.176494599999984&dist=400&details=true");


            List<Root> roots = null;
            if (response.IsSuccessStatusCode)
            {
                string rootString = await response.Content.ReadAsStringAsync();
                roots = JsonConvert.DeserializeObject<List<Root>>(rootString);
            }
            a(roots);
        }
    }
}
