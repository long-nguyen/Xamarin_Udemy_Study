using System;
using System.Collections.Generic;
using TestXamarin.Model;
using Xamarin.Forms;

namespace TestXamarin
{
    public partial class ListViewSample : ContentPage
    {
        
        public ListViewSample()
        {
            InitializeComponent();
            var addr = "http://sociorocketnewsen.files.wordpress.com/2013/08/foodsample1.jpg?w=580&h=435";
            var names = new List<Contact>()
            {
                new Contact{ name = "Long", avatar=addr, mobile="0976267764"},
                new Contact{ name = "Quan", avatar=addr, mobile="098712312"},
                new Contact{ name = "Trung", avatar=addr, mobile="081283123"},
                new Contact{ name = "Ha", avatar=addr, mobile="092323211"}
            };
            myList.ItemsSource = names;
        }
    }
}
