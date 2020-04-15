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

            List<MyList> list = new List<MyList>();
            list.Add(new MyList { Title = "Floating Button" });
            list.Add(new MyList { Title = "Fab Menu" });
            list.Add(new MyList { Title = "Half Circle Fab Menu" });
            list.Add(new MyList { Title = "Full Circle Fab Menu" });

            listview.ItemsSource = list;
        }


        public class MyList
        {
            public string Title { get; set; }
        }

        void listview_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            MyList mylist = e.Item as MyList;
            if(mylist.Title == "Fab Menu")
            {
                Navigation.PushAsync(new FabMenu());
            }
            else if(mylist.Title == "Floating Button")
            {
                Navigation.PushAsync(new FloatingButton());
            }
            else if (mylist.Title == "Half Circle Fab Menu")
            {
                Navigation.PushAsync(new HalfCircleFabMenu());
            }
        }
    }
}
