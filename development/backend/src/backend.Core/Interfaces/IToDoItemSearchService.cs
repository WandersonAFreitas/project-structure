using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Result;
using backend.Core.Entities;

namespace backend.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync();
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(string searchString);
    }
}
