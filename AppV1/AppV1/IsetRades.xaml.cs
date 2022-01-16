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
    public partial class IsetRades : TabbedPage
    {
        public async void BtnCliked121(object sender, EventArgs e)
        {

            await App.Current.MainPage.Navigation.PushAsync(new Login());
        }
        public IsetRades()
        {
            InitializeComponent();
        }
    }
}