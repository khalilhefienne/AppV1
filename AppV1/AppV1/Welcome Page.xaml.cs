using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppV1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome_Page : ContentPage
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }
        private async void BtnCliked11(object sender, EventArgs e)
        {
           
            await App.Current.MainPage.Navigation.PushAsync(new Login());
        }

        public async void Mag(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new HomeMasterDetails());
        }

        public async void Iset(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new IsetRades());
        }

        public async void Voit(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new Voiture());
        }


    
    }
}