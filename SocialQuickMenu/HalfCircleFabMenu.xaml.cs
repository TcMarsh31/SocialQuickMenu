using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialQuickMenu
{
    public partial class HalfCircleFabMenu : ContentPage
    {
        public HalfCircleFabMenu()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tapped_3(System.Object sender, System.EventArgs e)
        {
            Image image = sender as Image;
            string filename = image.Source.ToString();
            if (filename == "File: close.png")
            {
                await Task.WhenAll(
                    lastIcon1.TranslateTo( - 100,  + 100, 300),
                    lastIcon2.TranslateTo( - 100,  - 100, 300)
                    ) ;
                lastIcon1.IsVisible = false;
                lastIcon2.IsVisible = false;

                await Task.WhenAll(
                    BtwIcon1.TranslateTo( - 150, 0 , 400),
                    BtwIcon2.TranslateTo( - 150, 0 , 400),
                    lastIcon1.TranslateTo( - 150, 0 , 400),
                lastIcon2.TranslateTo( - 150,0 , 400)
                );

                BtwIcon1.IsVisible = false;
                BtwIcon2.IsVisible = false;


                await Task.WhenAll(centerIcon.TranslateTo(0,0, 300),
                    BtwIcon1.TranslateTo(0,0, 400),
                    BtwIcon2.TranslateTo(0,0, 400),
                    lastIcon1.TranslateTo(0,0, 400),
                lastIcon2.TranslateTo(0,0, 400)
                    );
                contentPage.Opacity = 1;
                menu.Source = "share.png";
                centerIcon.IsVisible = false;
                contentPage.InputTransparent = false;
            }
            else if (filename == "File: share.png")
            {
                contentPage.Opacity = 0.3;
                menu.Source = "close.png";
                centerIcon.IsVisible = true;
                await Task.WhenAll(
                BtwIcon1.TranslateTo( - 150, 0, 300),
                BtwIcon2.TranslateTo( - 150, 0, 300),
                lastIcon1.TranslateTo( - 150, 0, 300),
                lastIcon2.TranslateTo(- 150, 0, 300),
                centerIcon.TranslateTo( - 150, 0, 300)
                );

                BtwIcon1.IsVisible = true;
                BtwIcon2.IsVisible = true;
                await Task.WhenAll(
                    BtwIcon1.TranslateTo( - 100,  + 100, 400),
                    BtwIcon2.TranslateTo( - 100, - 100, 400),
                    lastIcon1.TranslateTo( - 100,  + 100, 400),
                lastIcon2.TranslateTo( - 100,  - 100, 400)
                );

                lastIcon1.IsVisible = true;
                lastIcon2.IsVisible = true;
                await Task.WhenAll(lastIcon1.TranslateTo( - 10, + 150, 300),
                lastIcon2.TranslateTo( - 10,  - 150, 300)
                );

                contentPage.InputTransparent = true;
            }
        }

        void TapGestureRecognizer_TappedInsta2(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("ALERT","Insta icon2 clicked","OK");
        }
        void TapGestureRecognizer_TappedInsta1(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("ALERT", "Insta icon1 clicked", "OK");
        }
        void TapGestureRecognizer_TappedFB(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("ALERT", "Facebook icon clicked", "OK");
        }
        void TapGestureRecognizer_TappedTwit1(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("ALERT", "Twitter icon1 clicked", "OK");
        }
        void TapGestureRecognizer_TappedTwit2(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("ALERT", "Twitter icon2 clicked", "OK");
        }
        
    }
}
