namespace RedListSpecies.RedListApi
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Options;
    using Newtonsoft.Json;

    public abstract class ClientBase<T>
    {
        Configuration configuration;
        HttpClient httpClient;

        public ClientBase(HttpClient httpClient, IOptions<Configuration> options)
        {
            this.configuration = (options ?? throw new ArgumentNullException(nameof(options))).Value;
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            this.httpClient.BaseAddress = new Uri(options.Value.Url);
            this.httpClient.DefaultRequestHeaders.Accept.Clear();
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected async Task<T> ExecuteGet(string path = "")
        {
            path = path ?? throw new ArgumentNullException(nameof(path));
            path = $"{path}?token={this.configuration.Token}";
            HttpResponseMessage response = await httpClient.GetAsync(path, HttpCompletionOption.ResponseHeadersRead);
            response = response.EnsureSuccessStatusCode();
            var responseStr = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseStr);
            return result;
            //return await response.Content.ReadAsAsync<T>();
        }
    }
}
