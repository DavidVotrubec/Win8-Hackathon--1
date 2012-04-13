using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RssGoLibrary
{
    public struct RssFeedItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime PubDate { get; set; }
        public Uri Link { get; set; }
    }
}
