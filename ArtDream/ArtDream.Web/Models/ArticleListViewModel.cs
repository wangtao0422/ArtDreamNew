using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtDream.Web.Models
{
    public class ArticleListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public string CreatedOn { get; set; }
        public bool Published { get; set; }
    }
}