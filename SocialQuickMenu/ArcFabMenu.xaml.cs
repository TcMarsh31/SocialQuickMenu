using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialQuickMenu
{
    public partial class ArcFabMenu : ContentPage
    {
        public ArcFabMenu()
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
                grid.BackgroundColor = Color.Transparent;
                contentPage.BackgroundColor = Color.LightBlue;
                title.IsVisible = false;
                menu.Source = "share.png";
                menu.WidthRequest = 50;
                menu.HeightRequest = 50;
                await Task.WhenAll(
                    fb.TranslateTo(fab.X+10 , fab.Y),
                    twit.TranslateTo(fab.X+10, fab.Y),
                    fb2.TranslateTo(fab.X + 10, fab.Y),
                    twit2.TranslateTo(fab.X + 10, fab.Y)
                    );
             
                fb.IsVisible = false;
                twit.IsVisible = false;
                fb2.IsVisible = false;
                twit2.IsVisible = false;
                contentPage.InputTransparent = false;
            }
            else if (filename == "File: share.png")
            {
                contentPage.Opacity = 0.3;
                grid.BackgroundColor = Color.Purple;
                title.IsVisible = true;
                contentPage.BackgroundColor = Color.Transparent;
                menu.Source = "close.png";
                menu.WidthRequest = 30;
                menu.HeightRequest = 30;

                fb.TranslateTo(fb.X -200, fb.Y+40);
                twit.TranslateTo(twit.X - 160, twit.Y - 50);
                fb2.TranslateTo(fb2.X - 90, fb2.Y - 120);
                twit2.TranslateTo(twit2.X , twit2.Y - 170);
                fb.IsVisible = true;
                twit.IsVisible = true;
                fb2.IsVisible = true;
                twit2.IsVisible = true;
                contentPage.InputTransparent = true;
            }
        }
    }
}
