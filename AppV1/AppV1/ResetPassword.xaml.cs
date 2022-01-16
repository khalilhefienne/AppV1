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
    public partial class ResetPassword : ContentPage
    {
        public ResetPassword()
        {
            InitializeComponent();
        }
        public async void reset(object sender, EventArgs e)
        {
            if (validData())
            {
                if (password.Text == ConfirmPassword.Text)
                {

                    await App.sqliteHelperDB.UpdateUserAsync(email.Text, password.Text);

                    email.Text = "";
                    password.Text = "";
                    await DisplayAlert("Reset password", "Success", "OK");
                    await App.Current.MainPage.Navigation.PushAsync(new Login());
                }
                else { await DisplayAlert("Warning", " password and confirm Password are not matched", "OK"); }


            }
            else
            {
                await DisplayAlert("Alert", "There is an error", "OK");

            }
        }
        public bool validData()
        {
            bool response = true;
            if (string.IsNullOrEmpty(email.Text) && string.IsNullOrEmpty(password.Text) && string.IsNullOrEmpty(ConfirmPassword.Text))
            {
                response = false;
            }
            return response;
        }
    }
}
