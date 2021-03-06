using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private async void coffeeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CoffeeDrinksDetailPage());
        }

        private async void HotDrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinks());
        }

        private async void ColdDrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinks());
        }
        private async void BitesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bites());
        }
    }
}