using System.Collections.Generic;

namespace EventsAndApis.Model
{
    public class Response
    {
        public IList<Venue> venues { get; set; }
        public bool confident { get; set; }
    }
}
