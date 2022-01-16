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
    public partial class master : ContentPage
    {
        public master()
        {
            InitializeComponent();
        }
        private async void Btn1Cliked(object sender,EventArgs e) {
            App.MasterDetailP.IsPresented = false;
            await App.MasterDetailP.Detail.Navigation.PushAsync(new  Choix1());

        }
        private async void BtnClikedL(object sender, EventArgs e)
        {
            App.MasterDetailP.IsPresented = false;
            await App.MasterDetailP.Detail.Navigation.PushAsync(new Login());
        }

        private async void Btn2Cliked(object sender, EventArgs e) {
            App.MasterDetailP.IsPresented = false;
            await App.MasterDetailP.Detail.Navigation.PushAsync(new Choix2());
        }

        private async void Btn3Cliked(object sender, EventArgs e) {
            App.MasterDetailP.IsPresented = false;
            await App.MasterDetailP.Detail.Navigation.PushAsync(new Choix3());
        }
    }
}