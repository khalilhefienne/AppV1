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
    public partial class HomeMasterDetails : MasterDetailPage
    {
        public HomeMasterDetails()
        {
            InitializeComponent();
            this.Master = new master();
            this.Detail = new NavigationPage(new detail());
            App.MasterDetailP = this;

        }
    }
}