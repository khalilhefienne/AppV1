using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppV1.Models;

namespace AppV1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        public async void register(object sender, EventArgs e)
        {
            if(validData())
            {
                if (password.Text == ConfirmPassword.Text)
                {
                    User user = new User
                    {
                        email = email.Text,
                        Password = password.Text
                    };
                    await App.sqliteHelperDB.SaveUser(user);

                    email.Text = "";
                    password.Text = "";
                    await DisplayAlert("Registration", "avec Success", "OK");
                    await App.Current.MainPage.Navigation.PushAsync(new Login());
                }
                else { await DisplayAlert("erreur", "mot de passe n est pas identique", "OK"); }


            }
            else
            {
                await DisplayAlert("erreur !!", "il ya un probleme", "OK");

            }
        }
        public bool validData()
        {
            bool response=true;
            if(string.IsNullOrEmpty(email.Text) && string.IsNullOrEmpty(password.Text) && string.IsNullOrEmpty(ConfirmPassword.Text))
            {
                response = false;
            }
            return response;
        }
    }
}