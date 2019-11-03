using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UReventV2.Pages
{
    public partial class friendsPage : ContentPage
    {
        private IEnumerable<string> testListbis;

        class Friend
        { 
            public string Id { get; private set; }
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public string Picture { get; private set; }

            public Friend(string id, string firstName, string lastName, string picture)
            {
                this.Id = id;
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Picture = picture;
            }
        }

        public friendsPage()
        {
            List<Friend> friendList = new List<Friend> {
                            new Friend("1","Thomas","Anino","randomPicture"),
                            new Friend("2","Greg","Riballoff","randomPicture"),
                            new Friend("3","Alan","Lima","randomPicture"),
                            new Friend("4","Emma","Normand","randomPicture"),
                            new Friend("5","Ouijdane","COUCOU","randomPicture"),
                            new Friend("6","Philippe","Hospitalier","randomPicture"),
                            new Friend("7","Julien","Enretard","randomPicture"),
                            new Friend("8","Asta","Bricot","randomPicture"),
                            new Friend("9","Kevin","Anino","randomPicture"),
                            new Friend("10","Cassandra","Fournier","randomPicture"),
                            new Friend("11", "Clement", "Dupont", "randomPicture")};

            var table = new TableView();
            table.Intent = TableIntent.Settings;

            // Create the ListView.
            ListView listView = new ListView
            {
                // Source of data items.
                ItemsSource = friendList,

                // Define template for displaying each item.
                // (Argument of DataTemplate constructor is called for 
                //      each item; it must return a Cell derivative.)
                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label firstNameLabel = new Label();
                    firstNameLabel.SetBinding(Label.TextProperty, "FirstName");

                    Label lastNameLabel = new Label();
                    lastNameLabel.SetBinding(Label.TextProperty,"LastName");

                    Button deleteButton = new Button();
                    deleteButton.SetBinding(Button.TextProperty, "Delete");

                    // Return an assembled ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(5, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                                {
                                    new StackLayout
                                    {
                                        VerticalOptions = LayoutOptions.Center,
                                        Orientation = StackOrientation.Horizontal,
                                        WidthRequest= 500,
                                        Children =
                                        {
                                            firstNameLabel,
                                            lastNameLabel
                                        }
                                    },
                                    deleteButton
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
