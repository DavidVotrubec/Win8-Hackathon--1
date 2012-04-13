using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using RssGoLibrary;

namespace RssGo
{
    public sealed partial class BlankPage : RssGo.Common.LayoutAwarePage
    {
        public BlankPage()
        {
            InitializeComponent();
        }



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = App.FeedDataSource;
            //Fill="{Binding Source={StaticResource SettingsWithBrush}, Path=Brush}"
        }

        private void ItemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
            RssFeedItem feedItem = e.AddedItems[0] as RssFeedItem;
            if (feedItem != null)
            {
                // Navigate the WebView to the blog post content HTML string.
                ContentView.NavigateToString(feedItem.Content);
                ContentView1.NavigateToString(feedItem.Content);
                ContentView2.NavigateToString(feedItem.Content);
            }
        }

    }
}
