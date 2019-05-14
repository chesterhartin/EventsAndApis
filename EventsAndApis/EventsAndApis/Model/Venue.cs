using System.Collections.Generic;
using System.Linq;

namespace EventsAndApis.Model
{
    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        public IList<Category> categories { get; set; }
        public string referralId { get; set; }
        public bool hasPerk { get; set; }

        public string MainCategory
        {
            // added using System.Linq;
            get { return categories.FirstOrDefault()?.name; }
        }
    }
}
