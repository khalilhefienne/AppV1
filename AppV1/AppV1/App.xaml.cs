using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppV1.Data;
using System.IO;

namespace AppV1
{
 
    public partial class App : Application
    {
        public static sqliteHelper db;
        public static MasterDetailPage MasterDetailP { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }
        //Connexion avec la base de donnees
        public static sqliteHelper sqliteHelperDB
        {
            get{
                if (db == null) {
                    db = new sqliteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "databaseISET.db")); }


                return db;

            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
