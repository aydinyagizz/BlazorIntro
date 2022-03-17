using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorIntro.Models;

namespace BlazorIntro.Services
{
    public interface IApiService
    {
        Task<TodoItem[]> GetTodos();
    }
}
