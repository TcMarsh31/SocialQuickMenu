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
                    lastIcon1.TranslateTo(centerIcon.X - 100, centerIcon.Y + 100, 300),
                    lastIcon2.TranslateTo(centerIcon.X - 100, centerIcon.Y - 100, 300)
                    ) ;
                lastIcon1.IsVisible = false;
                lastIcon2.IsVisible = false;

                await Task.WhenAll(
                    BtwIcon1.TranslateTo(centerIcon.X - 150, centerIcon.Y , 400),
                    BtwIcon2.TranslateTo(centerIcon.X - 150, centerIcon.Y , 400),
                    lastIcon1.TranslateTo(centerIcon.X - 150, centerIcon.Y , 400),
                lastIcon2.TranslateTo(centerIcon.X - 150, centerIcon.Y , 400)
                );

                BtwIcon1.IsVisible = false;
                BtwIcon2.IsVisible = false;


                await Task.WhenAll(centerIcon.TranslateTo(centerIcon.X + 0, centerIcon.Y, 300),
                    BtwIcon1.TranslateTo(centerIcon.X + 0, centerIcon.Y, 400),
                    BtwIcon2.TranslateTo(centerIcon.X + 0, centerIcon.Y, 400),
                    lastIcon1.TranslateTo(centerIcon.X + 0, centerIcon.Y, 400),
                lastIcon2.TranslateTo(centerIcon.X + 0, centerIcon.Y, 400)
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
                BtwIcon1.TranslateTo(centerIcon.X - 150, centerIcon.Y, 300),
                BtwIcon2.TranslateTo(centerIcon.X - 150, centerIcon.Y, 300),
                lastIcon1.TranslateTo(centerIcon.X - 150, centerIcon.Y, 300),
                lastIcon2.TranslateTo(centerIcon.X - 150, centerIcon.Y, 300),
                centerIcon.TranslateTo(centerIcon.X - 150, centerIcon.Y, 300)
                );

                BtwIcon1.IsVisible = true;
                BtwIcon2.IsVisible = true;
                await Task.WhenAll(
                    BtwIcon1.TranslateTo(centerIcon.X - 100, centerIcon.Y + 100, 400),
                    BtwIcon2.TranslateTo(centerIcon.X - 100, centerIcon.Y - 100, 400),
                    lastIcon1.TranslateTo(centerIcon.X - 100, centerIcon.Y + 100, 400),
                lastIcon2.TranslateTo(centerIcon.X - 100, centerIcon.Y - 100, 400)
                );

                lastIcon1.IsVisible = true;
                lastIcon2.IsVisible = true;
                await Task.WhenAll(lastIcon1.TranslateTo(centerIcon.X - 10, centerIcon.Y + 150, 300),
                lastIcon2.TranslateTo(centerIcon.X - 10, centerIcon.Y - 150, 300)
                );

                contentPage.InputTransparent = true;
            }
        }
    }
}
