using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookland.Models;

namespace Bookland.ViewModels
{
    public class RandomBookViewModel
    {
        public Book Book { get; set; }
        public List<Author> Authors { get; set; }
    }
}