using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace RssGoLibrary
{
    public class RssGoGateway
    {
        private const string SERVER_URL = "http://esf.cepelik.eu";
        private const string GET_FEED_UPDATES_URL = SERVER_URL + "/get-feeds";


        
        public delegate void GetFeedUpdatesEventHandler(List<RssFeedItem> updates);
        public event GetFeedUpdatesEventHandler GetFeedUpdates;



        private static RssGoGateway instance;

        private RssGoGateway()
        {
        }

        public static RssGoGateway Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RssGoGateway();
                }
                return instance;
            }
        }
        
        
        
        public void BeginGetFeedUpdates()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GET_FEED_UPDATES_URL);
            request.BeginGetResponse(GetFeedUpdatesCallback, request);
        }



        private void GetFeedUpdatesCallback(IAsyncResult result)
        {
            var request = result.AsyncState as HttpWebRequest;

            var response = (HttpWebResponse)request.EndGetResponse(result);
            var stream = response.GetResponseStream();
            var reader = new StreamReader(stream);
            string data = reader.ReadToEnd();

            var updates = new List<RssFeedItem>();
            List<Dictionary<string, object>> jsonUpdates = JsonConvert.DeserializeObject(data, typeof(List<Dictionary<string, object>>)) as List<Dictionary<string, object>>;
            foreach (Dictionary<string, object> jsonUpdate in jsonUpdates)
            {
                var update = new RssFeedItem
                {
                    Title = (string)jsonUpdate["title"],
                    Author = (string)jsonUpdate["author"],
                    Content = (string)jsonUpdate["description"],
                    Link = new Uri((string)jsonUpdate["link"]),
                    PubDate = new DateTime(1970, 1, 1).AddSeconds((double)jsonUpdate["timestamp"])
                };
                updates.Add(update);
            }

            if (GetFeedUpdates != null)
            {
                GetFeedUpdates(updates);
            }
        }
    }
}
