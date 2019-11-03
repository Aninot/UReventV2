using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UReventV2.Pages;
using Xamarin.Forms;

namespace UReventV2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button buttonCreate = new Button
            {
                Text = "Créer évent !",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            buttonCreate.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new createEventPage());
            };

            Button buttonFriends = new Button
            {
                Text = "Vos amis",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            buttonFriends.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new friendsPage());
            };

            Button buttonAccount = new Button
            {
                Text = "Vos paramètres",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            buttonAccount.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new accountPage());
            };

            Button buttonEvents = new Button
            {
                Text = "Liste des events",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            buttonEvents.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new evenementsPage());
            };

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    buttonFriends,
                    buttonCreate,
                    buttonAccount,
                    buttonEvents
                }
            }; 
        }
    }
}
