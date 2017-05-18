using Xamarin.Forms;
using System.Collections.Generic;
using System;

namespace TestXamarin
{
    public partial class TestXamarinPage : ContentPage
    {
        List<String> _quotes = new List<String>();

		public TestXamarinPage()
        {
            //Đoạn này dùng để xử lý XAML code
            InitializeComponent();
            initView();
        }

        private void initView() {
            _quotes.Add("This is a test 1");
            _quotes.Add("This is a test 2");
            _quotes.Add("This is a test 3");
            _quotes.Add("This is a test 4");
            this.updateText();
        }

        private void updateText() {
			Random rnd = new Random();
			int rn = rnd.Next(_quotes.Count);
			ContentLbl.Text = _quotes[rn];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.updateText();
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {

            ContentLbl.FontSize = e.NewValue;
        }
    }
}
