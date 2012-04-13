using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace RssGo
{
    public class GatewayMock
    {

        public delegate void GetFeedUpdatesEventHandler(List<FeedData> feeds);
        public event GetFeedUpdatesEventHandler GetFeedUpdates;
        private static GatewayMock instance;

        private GatewayMock() { }

        public static GatewayMock Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GatewayMock();
                }

                return instance;
            }
        }


       public void BeginGetFeedUpdates()
       {
           HttpWebRequest request = (HttpWebRequest)WebRequest.Create("just a mock url");
           request.BeginGetResponse(GetFeedUpdatesCallback, request);
       }

       

       private void GetFeedUpdatesCallback(IAsyncResult result)
       {

           IList<FeedData> feedData = new List<FeedData>();


           /*
           var request = result.AsyncState as HttpWebRequest;

           var response = (HttpWebResponse)request.EndGetResponse(result);
           var stream = response.GetResponseStream();
           var reader = new StreamReader(stream);
           string data = reader.ReadToEnd();

           if (GetFeedUpdates != null)
           {
               var updates = JsonConvert.DeserializeObject(data, typeof(List<object>));
               Dictionary<string, object> d = new Dictionary<string, object>();
               object o = d["5"];
               //foreach (Dictionary<string, object> update in updates)
           }
            * 
            * */
       }
    }
}
