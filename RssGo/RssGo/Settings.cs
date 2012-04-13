using System;
using System.ComponentModel;
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
            get { return new SolidColorBrush(Colors.White); }
        }
        public SolidColorBrush Background
        {
            get { return new SolidColorBrush(Colors.Black); }
        }
        public String FeedName
        {
            get { return "Plesk"; }
        }
        public int FeedNumber
        {
            get { return 1; }
        }

        //public SolidColorBrush AccentBrush
        //{
        //    get { return new SolidColorBrush(Colors.Red); }
        //}
        //public SolidColorBrush Foreground
        //{
        //    get { return new SolidColorBrush(Colors.Black); }
        //}
        //public SolidColorBrush Background
        //{
        //    get { return new SolidColorBrush(Colors.LightBlue); }
        //}
        //public String FeedName
        //{
        //    get { return "iDnes.cz"; }
        //}
        //public int FeedNumber
        //{
        //    get { return 2; }
        //}

    //    public SolidColorBrush AccentBrush
    //    {
    //        get { return new SolidColorBrush(Colors.LightGray); }
    //    }
    //    public SolidColorBrush Foreground
    //    {
    //        get { return new SolidColorBrush(Colors.Black); }
    //    }
    //    public SolidColorBrush Background
    //    {
    //        get { return new SolidColorBrush(Colors.White); }
    //    }
    //    public String FeedName
    //    {
    //        get { return "Dilbert"; }
    //    }
    //    public int FeedNumber
    //    {
    //        get { return 3; }
    //    }
    }
}