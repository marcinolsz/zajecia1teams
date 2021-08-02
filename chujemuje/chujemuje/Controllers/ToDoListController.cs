using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace dzikieweze.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoListController : ControllerBase
    {
        private readonly ILogger<ToDoListController> _logger;
        private readonly IToDoList _service;

        public ToDoListController(ILogger<ToDoListController> logger, IToDoList service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IEnumerable<MyTask> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public MyTask Get(Guid id)
        {
            return _service.GetSpecified(id);
        }

        [HttpPost]
        public void Post([FromBody]MyTask task)
        {
            _service.AddSpecified(task);
        }

        [HttpPatch]
        public void Patch([FromBody]MyTask task)
        {
            _service.UpdateSpecified(task);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.DeleteSpecified(id);
        }

        [HttpDelete]
        public void DeleteAll()
        {
            _service.DeleteAll();
        }

    }
}
