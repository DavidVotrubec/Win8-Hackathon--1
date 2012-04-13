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

namespace RssGo
{
    public sealed partial class BlankPage : RssGo.Common.LayoutAwarePage
    {
        public BlankPage()
        {
            InitializeComponent();
        }



        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = App.FeedDataSource;
        }
    }
}
