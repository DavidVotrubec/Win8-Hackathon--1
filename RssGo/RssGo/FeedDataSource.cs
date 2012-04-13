using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using RssGoLibrary;

namespace RssGo
{
    public class FeedDataSource
    {
        private ObservableCollection<RssFeedItem> feeds = new ObservableCollection<RssFeedItem>();
        public ObservableCollection<RssFeedItem> Feeds
        {
            get
            {

                feeds.Add(new RssFeedItem { Title = "zlo", Content = "dobrou chut"});

                return feeds;
            }
        }

        public void GetFeedAsync(int companyId, string anid)
        {
            var gatewayInstance = RssGoGateway.Instance;
            gatewayInstance.GetFeedUpdates += feedLoaded;

            gatewayInstance.BeginGetFeedUpdates(companyId, anid);
        }

        private void feedLoaded(List<RssFeedItem> feeds)
        {
            foreach (RssFeedItem rssFeedItem in feeds)
            {
                feeds.Add(rssFeedItem);
            }
        }
    }

}
