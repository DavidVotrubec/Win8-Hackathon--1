using System;
using Windows.UI;
using Windows.UI.Xaml.Media;


namespace RssGo
{
    public class Settings
    {
        public SolidColorBrush AccentBrush
        {
            get { return new SolidColorBrush(Colors.Red); }
        }
        public SolidColorBrush Foreground
        {
            get { return new SolidColorBrush(Colors.LightBlue); }
        }
        public SolidColorBrush Background
        {
            get { return new SolidColorBrush(Colors.DarkBlue); }
        }
        public String FeedName
        {
            get { return "Hello world!"; }
        }
    }
}