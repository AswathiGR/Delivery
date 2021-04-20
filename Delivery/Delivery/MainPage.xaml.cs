using Delivery.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Delivery
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage

    {
        List<food> places;
        public MainPage()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception e) 
            { 
            }  
            List<food> places = new List<food>
            {

            new food


            {
                Image = "rect_1.png",
                info = "Groceries and Essentials",
                arrow="arrow.png"
            },
            new food


            {
                Image = "rect_21.png",
                info = "Groceries and Essentials",
                arrow = "arrow.png"
            },
            new food


            {
                Image = "rect_22.png",
                info = "Groceries and Essentials",
                arrow = "arrow.png"
            },
            new food


            {
                Image = "rect_31.png",
                info = "Groceries and Essentials",
                arrow = "arrow.png"
            },
            new food


            {
                Image = "rect_32.png",
                info = "Groceries and Essentials",

                arrow = "arrow.png"
            },
            new food


            {
                Image = "rect_41.png",
                info = "Groceries and Essentials",
                arrow = "arrow.png"
            },
            new food


            {
                Image = "rect_42.png",
                info = "Groceries and Essentials",
                arrow = "arrow.png"
            },
            new food


            {
                Image = "rect_43.png",
                info = "Groceries and Essentials",
                arrow = "arrow.png"
            },
            new food


            {
                Image = "rect_44.png",
                info = "Groceries and Essentials",
                arrow = "arrow.png"
            },










            };
            FoodView.ItemsSource = places;

        }
        private void Go(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new View1());
        }
    }
  
}
