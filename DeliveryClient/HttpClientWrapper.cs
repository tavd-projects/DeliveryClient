using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace DeliveryClient
{
    public class HttpClientWrapper
    {
        private readonly Uri _baseUri;
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        
        public HttpClientWrapper(Uri baseUri) : this(baseUri, new HttpClient())
        {
        }

        public HttpClientWrapper(Uri baseUri, HttpClient client)
        {
            _baseUri = baseUri;
            _client = client;
        }

        public TResponseBody PostRequest<TRequestBody, TResponseBody>(TRequestBody requestBody, string path)
        {
            var postRequest = PostRequest(JsonSerializer.Serialize(requestBody), path);
            return JsonSerializer.Deserialize<TResponseBody>(postRequest, _jsonSerializerOptions);
        }

        public void PostRequest<TRequestBody>(TRequestBody requestBody, string path)
        {
            PostRequest(JsonSerializer.Serialize(requestBody), path);
        }

        public TResponseBody GetRequest<TResponseBody>(string path)
        {
            return JsonSerializer.Deserialize<TResponseBody>(GetRequest(path), _jsonSerializerOptions);
        }

        public TResponseBody UpdateRequest<TRequestBody, TResponseBody>(TRequestBody requestBody, string path)
        {
            return JsonSerializer.Deserialize<TResponseBody>(UpdateRequest(JsonSerializer.Serialize(requestBody),
                path), _jsonSerializerOptions);
        }

        public void UpdateRequest<TRequestBody>(TRequestBody requestBody, string path)
        {
            UpdateRequest(JsonSerializer.Serialize(requestBody), path);
        }

        private string PostRequest(string requestBody, string path)
        {
            return ProcessRequest(_client.PostAsync(new Uri(_baseUri, path),
                new StringContent(requestBody, Encoding.UTF8, "application/json")).Result);
        }

        private string GetRequest(string path)
        {
            return ProcessRequest(_client.GetAsync(new Uri(_baseUri, path)).Result);
        }

        private string UpdateRequest(string requestBody, string path)
        {
            return ProcessRequest(_client.PutAsync(new Uri(_baseUri, path),
                new StringContent(requestBody, Encoding.UTF8, "application/json")).Result);
        }

        private string ProcessRequest(HttpResponseMessage result)
        {
            var content = result.Content.ReadAsStringAsync().Result;

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"Error {result.StatusCode}. Content: " + content);
            }

            return content;
        }
    }
}