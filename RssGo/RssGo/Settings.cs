using System;
using Windows.UI;
using Windows.UI.Xaml.Media;


namespace RssGo
{
    public class Settings
    {
        public SolidColorBrush Brush
        {
            get { return new SolidColorBrush(Colors.Blue); }
        }
        public SolidColorBrush Foreground
        {
            get { return new SolidColorBrush(Colors.Red); }
        }
        public SolidColorBrush Background
        {
            get { return new SolidColorBrush(Colors.Green); }
        }
        public String ApplicationName
        {
            get { return "Hello world!"; }
        }
    }
}