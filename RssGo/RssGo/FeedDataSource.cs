using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading;
using Windows.UI.Core;
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
                return feeds;
            }
        }

        private CoreDispatcher dispatcher;
        public void InitDispatcher(CoreDispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
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
                dispatcher.Invoke(CoreDispatcherPriority.Normal, (o, e) =>
                    {
                        this.feeds.Add(rssFeedItem);
                    },
                    this, null);
            }
        }
    }

}
