using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module03Layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void StackLayout_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }

        private async void AbsoluteLayout_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        private async void RelativeLayout_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());
        }

        private async void Grid_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }
    }
}
