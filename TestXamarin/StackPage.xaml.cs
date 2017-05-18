using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestXamarin
{
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();
            //Stack layout viết bằng code
            var layout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(0, 20, 0, 0),
                Orientation = StackOrientation.Horizontal
            };
            layout.Children.Add(new Label());
        }
    }
}
