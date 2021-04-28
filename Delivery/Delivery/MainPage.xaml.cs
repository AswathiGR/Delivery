
using Delivery.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Delivery
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage

    {
        ObservableCollection<food> places;
        public MainPage()
        {
            InitializeComponent();
            
            places = new ObservableCollection<food>();
            //places.Add(new food


            //{
            //    Image = "rect_1.png",
            //    info = "Groceries and Essentials",
            //    arrow = "arrow.png"
            //});
            places.Add(new food


            {
                Image1= "rect_21.png",
                info = "Groceries&\nEssentials",
                arrow = "backarrow.png"
            });
            places.Add(new food


            {
                Image2= "rect_22.png",
                info = "Groceries&\nEssentials",
                arrow = "backarrow.png"
            });
            places.Add(new food


            {
                Image1 = "rect_31.png",
                info = "Groceries&\nEssentials",
                arrow = "backarrow.png"
            });
            places.Add(new food


            {
                Image2 = "rect_32.png",
                info = "Groceries&\nEssentials",

                arrow = "backarrow.png"
            });
            places.Add(new food


            {
                Image1 = "rect_21.png",
                info = "Groceries&\nEssentials",
                arrow = "backarrow.png"
            });
            places.Add(new food


            {
                Image2 = "rect_22.png",
                info = "Groceries&\nEssentials",
                arrow = "backarrow.png"
            });
            places.Add(new food


            {
                Image1 = "rect_31.png",
                info = "Groceries&\nEssentials",
                arrow = "backarrow.png"
            });
            places.Add(new food


            {
                Image2 = "rect_32.png",
                info = "Groceries and Essentials",

                arrow = "backarrow.png"
            });
            //   places.Add(new food


            //{
            //  //  Image11="rect_41.png",
            //    //info = "Groceries and Essentials",
            //    arrow = "arrow.png"
            //});
            //places.Add(new food


            //{
            //  //  Image12="rect_42.png",
            //    //info = "Groceries and Essentials",
            //    arrow = "arrow.png"
            //});
            //places.Add(new food


            //{
            //   // Image13 = "rect_43.png",
            //    //info = "Groceries and Essentials",
            //    arrow = "arrow.png"
            //});
            //places.Add(new food


            //{
            //    Image14 = "rect_44.png",
            //   // info = "Groceries and Essentials",
            //    arrow = "arrow.png"
            //});







            FoodView.ItemsSource = places;
        }
        private async void Go(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void search(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}

