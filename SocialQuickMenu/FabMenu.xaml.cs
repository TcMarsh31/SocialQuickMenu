using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SocialQuickMenu
{
    public partial class FabMenu : ContentPage
    {
        public FabMenu()
        {
            InitializeComponent();
        }

        void close(System.Object sender, System.EventArgs e)
        {
            contentPage.Opacity = 1;
            menuitems.IsVisible = false;
        }


        async void TapGestureRecognizer_Tapped_3(System.Object sender, System.EventArgs e)
        {
            Image image = sender as Image;
            string filename = image.Source.ToString();
            if (filename == "File: close.png")
            {
                contentPage.Opacity = 1;
                menu.Source = "share.png";
                await menulist.FadeTo(0);
                menulist.IsVisible = false;
                contentPage.InputTransparent = false;
            }
            else if (filename == "File: share.png")
            {
                contentPage.Opacity = 0.3;
                menu.Source = "close.png";
                await menulist.FadeTo(1,0,Easing.SinIn);
                menulist.IsVisible = true;
                contentPage.InputTransparent = true;
            }
        }
    }

}
