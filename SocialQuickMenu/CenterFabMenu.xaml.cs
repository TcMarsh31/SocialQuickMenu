using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialQuickMenu
{
    public partial class CenterFabMenu : ContentPage
    {
        public CenterFabMenu()
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
                //When close button is pressed
                contentPage.Opacity = 1; // make back the mainpage opacity to 1
                grid.BackgroundColor = Color.Transparent;
                contentPage.BackgroundColor = Color.LightBlue;
                title.IsVisible = false;
                menu.Source = "share.png";
                menu.WidthRequest = 50;
                menu.HeightRequest = 50;

                //wait until all the translate completes
                await Task.WhenAll(
                    fb.TranslateTo(fab.X + 10, fab.Y),
                    twit.TranslateTo(fab.X + 10, fab.Y),
                    fb2.TranslateTo(fab.X + 10, fab.Y),
                    twit2.TranslateTo(fab.X + 10, fab.Y),
                    fb3.TranslateTo(fab.X + 10, fab.Y),
                    twit3.TranslateTo(fab.X + 10, fab.Y)

                    );

                fb.IsVisible = false;
                twit.IsVisible = false;
                fb2.IsVisible = false;
                twit2.IsVisible = false;
                fb3.IsVisible = false;
                twit3.IsVisible = false;
                contentPage.InputTransparent = false;
            }
            else if (filename == "File: share.png")
            {
                //when share fab button is pressed

                contentPage.Opacity = 0.3;
                grid.BackgroundColor = Color.Purple;
                title.IsVisible = true;
                contentPage.BackgroundColor = Color.Transparent;
                menu.Source = "close.png";
                menu.WidthRequest = 30;
                menu.HeightRequest = 30;

                fb.TranslateTo(fb.X - 160, fb.Y);
                twit.TranslateTo(twit.X - 120, twit.Y - 80);
                fb2.TranslateTo(fb2.X - 40, fb2.Y - 140);
                twit2.TranslateTo(twit2.X + 40, twit2.Y - 140);
                fb3.TranslateTo(fb3.X + 120, fb3.Y - 80);
                twit3.TranslateTo(twit3.X + 160, twit3.Y);
                
                fb.IsVisible = true;
                twit.IsVisible = true;
                fb2.IsVisible = true;
                twit2.IsVisible = true;
                fb3.IsVisible = true;
                twit3.IsVisible = true;
                contentPage.InputTransparent = true;

            }
        }
    }
}
