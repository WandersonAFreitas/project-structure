using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Core.Entities;
using backend.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace backend.Web.Pages.ToDoRazorPage
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;

        public List<ToDoItem> ToDoItems { get; set; }

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }

        public async Task OnGetAsync()
        {
            ToDoItems = await _repository.ListAsync<ToDoItem>();
        }
    }
}
