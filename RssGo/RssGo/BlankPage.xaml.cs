using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
            App.FeedDataSource.InitDispatcher(Dispatcher);
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
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
                ContentView.Navigate(new Uri(feedItem.Link, UriKind.Absolute));
                ContentView1.Navigate(new Uri(feedItem.Link, UriKind.Absolute));
                ContentView2.Navigate(new Uri(feedItem.Link, UriKind.Absolute));

                ContentView.Visibility = Visibility.Visible;
                ContentView1.Visibility = Visibility.Visible;
                ContentView2.Visibility = Visibility.Visible;
            }
        }

    }
}
