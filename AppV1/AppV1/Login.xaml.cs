using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppV1.Models;
using AppV1.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppV1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

        }
        public async void account(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new Register());
        }

            public async void login(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
            { await App.Current.MainPage.DisplayAlert("valeurs vides", "veuillez remplir vos champs", "OK"); }
            else
            {
                  
                var user = await App.sqliteHelperDB.GetUser(username.Text);
                
                if (user != null)
                    if (username.Text == user.email && password.Text == user.Password)
                    { 
                        await App.Current.MainPage.Navigation.PushAsync(new Welcome_Page());
                    }
                    else
                        await App.Current.MainPage.DisplayAlert("erreur !!", "verifier vos donnees", "OK");
                else
                    await App.Current.MainPage.DisplayAlert("Login Fail", "utilisateur pas trouve", "OK");
            }

          
        }

 

    }


}