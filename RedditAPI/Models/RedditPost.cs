using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditAPI.Models
{
    public class RedditPost
    {
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string LinkURL { get; set; }
        public string data { get; set; }
    }
}