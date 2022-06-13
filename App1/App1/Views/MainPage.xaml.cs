using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Views;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Cette fonction renvoie à la page d'acceuil
        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Acceuil2());
        }
    }
}
