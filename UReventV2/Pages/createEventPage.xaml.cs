using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UReventV2.Pages
{
    public partial class createEventPage : ContentPage
    {
        public createEventPage()
        {
            InitializeComponent();

            string[] listeStyle = { "Pas de thème","Rock", "Pop", "Electro", "Hip-Hop", "Country","Jazz","RnB","Classique","Slam" };

            var styles = new List<string>();

            foreach (string i in listeStyle)
            {
                styles.Add(i);
            }

            themePicker.ItemsSource = styles;
        }

        async void createEvent(object sender, EventArgs args)
        {
            await DisplayAlert(title: "event created", message: "l'event as bien été créé", cancel: "yes");
        }
    }
}
