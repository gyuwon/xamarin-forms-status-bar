using System;
using MonoTouch.UIKit;
using NavigationApp;
using NavigationApp.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageRenderer))]

namespace NavigationApp.iOS.Renderers
{
    public class MainPageRenderer : NavigationRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationBar.TintColor = UIColor.White;
            NavigationBar.BarTintColor = UIColor.FromRGB(0x81, 0xa9, 0xa8);
            NavigationBar.BarStyle = UIBarStyle.Black;
        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }
    }
}