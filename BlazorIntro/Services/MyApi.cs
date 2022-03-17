using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorIntro.Models;

namespace BlazorIntro.Services
{
    public class MyApi : IApiService
    {
        private HttpClient _http;

        public MyApi(HttpClient http)
        {
            _http = http;
        }
        public Task<TodoItem[]> GetTodos()
        {
            return _http.GetFromJsonAsync<TodoItem[]>("https://jsonplaceholder.typicode.com/todos");
        }
    }
}
