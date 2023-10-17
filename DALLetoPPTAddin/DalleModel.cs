using System.Collections.Generic;

namespace DallePPT.Models
{
    // serves as our input model
    public class input
    {
        public string prompt { get; set; }
        public short n { get; set; }
        public string size { get; set; }
        //public string api_key { get; set; }
    }
    // model for the image url
    public class Link
    {
        public string url { get; set; }
    }
    public class DalleModel
    {
        public long created { get; set; }
        public List<Link> data { get; set; }
    }
}
