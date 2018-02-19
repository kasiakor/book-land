using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookland.Models
{
    public class Bookset
    {
        public string ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public int Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }

    }
}

