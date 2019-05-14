using System.Collections.Generic;

namespace EventsAndApis.Model
{
    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
        public IList<LabeledLatLng> labeledLatLngs { get; set; }
        public int distance { get; set; }
        public string cc { get; set; }
        public string country { get; set; }
        public IList<string> formattedAddress { get; set; }

        private string coordinates;
        public string Coordinates
        {
            get { return $"{lat:0.000}, {lng:0.000}"; }
        }
    }
}
