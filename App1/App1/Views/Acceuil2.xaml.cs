using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    public partial class Acceuil2 : TabbedPage
    {
        //Ajout du serveur Smtp
        SmtpClient SmtpServer;
        public Acceuil2()
        {
            InitializeComponent();
            
        }
        private async void Logout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
        //Fonction permettant d'envoyer un mail
        private void SendMail(object sender, System.EventArgs e)
        {
            try
            {
               SmtpServer = new SmtpClient("smtp.gmail.com");

                SmtpServer.Port = 465;
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;

                SmtpServer.Credentials = new System.Net.NetworkCredential("luigifury69@gmail.com", GlobalVariables.Password);

                SmtpServer.SendAsync(GlobalVariables.FromEmail, Email.Text, Sujet.Text, Body.Text, "xyz123d");

                SmtpServer.SendCompleted += emailSendCompleted;
 


         }
            catch (Exception ex)
            {
               DisplayAlert("Failed", ex.Message, "OK");
            }
        }
        //Cette fonction verifie si le mail est correct ou pas
        private void ValidateEmail(object sender, EventArgs e)
        {
            string email = Email.Text;
            btnSend.IsEnabled = Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        private async void emailSendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            await DisplayAlert("Message", "Le mail a bien été envoyé", "OK");
            await Navigation.PushModalAsync(new Acceuil2());
        }

}
}