using Microsoft.AspNetCore.Mvc;

namespace backend.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
