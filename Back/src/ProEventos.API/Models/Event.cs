using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string EventDate { get; set; }
        public string Thema { get; set; }
        public int PeapleQnt { get; set; }
        public string Lot { get; set; }
        public string ImageURL { get; set; }

    }
}