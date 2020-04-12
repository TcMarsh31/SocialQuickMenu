using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialQuickMenu
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

      

        void close(System.Object sender, System.EventArgs e)
        {
            contentPage.Opacity = 1;
            menuitems.IsVisible = false;
        }


        void TapGestureRecognizer_Tapped_3(System.Object sender, System.EventArgs e)
        {
            Image image = sender as Image;
            string filename = image.Source.ToString();
            if (filename == "File: close.png")
            {
                contentPage.Opacity = 1;
                menu.Source = "share.png";
                menulist.IsVisible = false;
                contentPage.InputTransparent = false;
            }
            else if (filename == "File: share.png")
            {
                contentPage.Opacity = 0.3;
                menu.Source = "close.png";
                menulist.IsVisible = true;
                contentPage.InputTransparent = true;
            }
        }

    }
}
