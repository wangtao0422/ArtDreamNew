using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtDream.Web.Models
{
    public class ArticleViewModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Type { get; set; }
        public bool Published { get; set; }
    }
}