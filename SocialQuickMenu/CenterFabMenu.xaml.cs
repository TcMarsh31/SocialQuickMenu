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
                    fb.TranslateTo(0,0),
                    twit.TranslateTo(0,0),
                    fb2.TranslateTo(0,0),
                    twit2.TranslateTo(0,0),
                    fb3.TranslateTo(0,0),
                    twit3.TranslateTo(0,0)

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
                fb.IsVisible = true;
                twit.IsVisible = true;
                fb2.IsVisible = true;
                twit2.IsVisible = true;
                fb3.IsVisible = true;
                twit3.IsVisible = true;
                contentPage.InputTransparent = true;

                contentPage.Opacity = 0.3;
                grid.BackgroundColor = Color.Purple;
                title.IsVisible = true;
                contentPage.BackgroundColor = Color.Transparent;
                menu.Source = "close.png";
                menu.WidthRequest = 30;
                menu.HeightRequest = 30;

                fb.TranslateTo(- 160, 0);
                twit.TranslateTo(- 120,  - 80);
                fb2.TranslateTo(- 40,  - 140);
                twit2.TranslateTo(+ 40,  - 140);
                fb3.TranslateTo( + 120,  - 80);
                twit3.TranslateTo( + 160, 0);
                
                

            }
        }
    }
}
