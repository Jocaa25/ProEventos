using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        private readonly ILogger<EventController> _logger;
        private readonly DataContext _context;
     
       public EventController(DataContext context)
       {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
           return _context.Events;
        }

         [HttpGet("{id}")]
        public Event GetById(int id)
        {
             return _context.Events.FirstOrDefault(e => e.EventId == id);
        }

        [HttpPost]
        public String Post()
        {
           return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
           return $"Exemplo de Put{id}";
        }

        [HttpDelete("{id}")]
        public String Delete(int id)
        {
           return $"Exemplo de Delete{id}";
        }
    }
}
