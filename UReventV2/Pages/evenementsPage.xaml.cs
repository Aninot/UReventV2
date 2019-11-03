using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UReventV2.Pages
{
    public partial class evenementsPage : ContentPage
    {
        public evenementsPage()
        {
                List<Evenement> eventList = new List<Evenement> {
                        new Evenement("1","Super soirée de Baptiste", "Halloween","1 rue de chez Marie", "0", "fete", "31/10/19 21.30.00", "1/11/19 7.00.00"),
                        new Evenement("2","Thomas's Party !", "Birthday","1 rue de chantepuits, Herblay", "10", "Anniv", "07/08/19 21.30.00", "08/08/19 7.00.00"),
                        new Evenement("3","Super soirée de Marc", "Halloween","1 rue de chez Marie", "2", "fete", "31/10/19 21.30.00", "1/11/19 7.00.00"),
                        new Evenement("4","Super soirée de Alex", "Halloween","1 rue de chez Marie", "0", "fete", "31/10/19 21.30.00", "1/11/19 7.00.00"),
                        new Evenement("5","Super soirée de Cassandra", "Halloween","1 rue de chez Marie", "0", "fete", "31/10/19 21.30.00", "1/11/19 7.00.00"),
                        new Evenement("6","Super soirée de Emma", "Halloween","1 rue de chez Marie", "0", "fete", "31/10/19 21.30.00", "1/11/19 7.00.00"),
                        new Evenement("7","Super soirée de Greg", "Halloween","1 rue de chez Marie", "200", "fete", "31/10/19 21.30.00", "1/11/19 7.00.00")
            };

                var table = new TableView();
                table.Intent = TableIntent.Settings;

                // Create the ListView.
                ListView listView = new ListView
                {
                    // Source of data items.
                    ItemsSource = eventList,

                    // Define template for displaying each item.
                    // (Argument of DataTemplate constructor is called for 
                    //      each item; it must return a Cell derivative.)
                    ItemTemplate = new DataTemplate(() =>
                    {
                        // Create views with bindings for displaying each property.
                        Label NameLabel = new Label();
                        NameLabel.SetBinding(Label.TextProperty, "Name");

                        Label priceLabel = new Label();
                        priceLabel.SetBinding(Label.TextProperty, "Price");

                        Button detailButton = new Button();
                        detailButton.SetBinding(Label.TextProperty, "Id");

                        detailButton.Clicked += async (sender, args) =>
                        {
                            await Navigation.PushAsync(new detailEventPage());
                        };

                        // Return an assembled ViewCell.
                        return new ViewCell
                        {
                            View = new StackLayout
                            {
                                Padding = new Thickness(5, 5),
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    NameLabel,
                                    priceLabel,
                                }
                            }
                        };
                    })
                };

                this.Content = new StackLayout
                {
                    Children =
                {
                    listView
                }
                };
            }
        }
    }