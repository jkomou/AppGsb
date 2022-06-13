using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Xamarin.Essentials;


namespace App1
{
    public partial class App : Application
    {
        
        
        //On va donner l'accés à la base de données dans toute l'application

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();       

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
