using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Models
{
    public class Snippet
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [System.Web.Mvc.AllowHtml]
        public string Content { get; set; }
    }
}