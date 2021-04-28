using Delivery.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Delivery
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            List<hotel> Places = new List<hotel>
            {
                new hotel
                {
                    Time = "Within 25 mins",
                    Picture = "paragon.png",
                    Name = "Paragon Restuarant",
                    Place = "Mananchira",
                },
                new hotel
                {
                    Time = "Within 25 mins",
                    Picture = "paragon.png",
                    Name = "Paragon Restuarant",
                    Place = "Mananchira",
                },
                new hotel
                {
                    Time = "Within 25 mins",
                    Picture = "paragon.png",
                    Name = "Paragon Restuarant",
                    Place = "Mananchira",
                },
                new hotel
                {
                    Time = "Within 25 mins",
                    Picture = "paragon.png",
                    Name = "Paragon Restuarant",
                    Place = "Mananchira",
                },
                new hotel
                {
                    Time = "Within 25 mins",
                    Picture = "paragon.png",
                    Name = "Paragon Restuarant",
                    Place = "Mananchira",
                },
                new hotel
                {
                    Time = "Within 25 mins",
                    Picture = "paragon.png",
                    Name = "Paragon Restuarant",
                    Place = "Mananchira",
                },
                new hotel
                {
                    Time = "Within 25 mins",
                    Picture = "paragon.png",
                    Name = "Paragon Restuarant",
                    Place = "Mananchira",
                },
               


            };
            hotelname.ItemsSource = Places;
        }

        private async void search(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}