using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;
        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            string message = _toDoService.SayHello();
            return Ok(new { Message = message });
        }
    }
}
