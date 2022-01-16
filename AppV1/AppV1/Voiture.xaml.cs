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
    public partial class Voiture : ContentPage
    {
        private async void BtnCliked11(object sender, EventArgs e)
        {
        }
        public Voiture()
        {
            InitializeComponent();
            var Images = new List<string>
            {
                "https://www.automobile-magazine.fr/asset/cms/840x394/167231/config/116046/la-golf-5-recoit-un-amortissement-plus-rigoureux-que-sa-devanciere.jpg",
               "https://i.pinimg.com/originals/0a/c9/1e/0ac91e6db79f53baa8aec8b54e7d8535.jpg",
               "https://cdn.jdpower.com/JDPA_2022%20Dodge%20Challenger%20GT%20RWD%20with%20Hemi%20Orange%20Appearance%20Package%20Front%20Quarter%20View.jpg",
               "https://cdn.motor1.com/images/mgl/XpwQ2/s1/4x3/2021-ford-mustang-mach-1.webp",
               "https://www.largus.fr/images/images/audi-q8-tfsi-e-quattro-av.jpg"
            };
        Carousel.ItemsSource = Images;
        }
    }

}