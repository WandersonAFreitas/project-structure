using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Core.Entities;
using backend.Core.Specifications;
using backend.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace backend.Web.Pages.ToDoRazorPage
{
    public class IncompleteModel : PageModel
    {
        private readonly IRepository _repository;

        public List<ToDoItem> ToDoItems { get; set; }

        public IncompleteModel(IRepository repository)
        {
            _repository = repository;
        }

        public async Task OnGetAsync()
        {
            var spec = new IncompleteItemsSpecification();

            ToDoItems = await _repository.ListAsync(spec);
        }
    }
}
