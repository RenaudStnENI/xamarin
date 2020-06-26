using module09_TP06.Entities;
using module09_TP06.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace module09_TP06
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService;
        NetworkAccess connection;


        public MainPage()
        {
            InitializeComponent();
            this.btnConnect.Clicked += BtnConnectClicked;
            this.errorMessage.IsVisible = false;
   
            this.connectionForm.IsVisible = true;
            this.twitterService = new TwitterServiceImpl();
        }

        private void BtnConnectClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("click");
            connection = Connectivity.NetworkAccess;

            String email = this.email.Text;
            String password = this.mdp.Text;
            Boolean isRemind = this.memorise.IsToggled;


            String erreurs;

            if (this.connection == NetworkAccess.Internet)
            {
                erreurs = this.twitterService.Authenticate(new User() { Email = email, Password = password });
                Debug.WriteLine("connection ok");
            }
            else
            {
                erreurs = "Pas de connection internet disponible";
                Debug.WriteLine("Pas de connection");

            }
            if (!String.IsNullOrEmpty(erreurs))
            {
                this.errorMessage.Text = erreurs;
                this.errorMessage.IsVisible = true;

            }
            else
            {
                Debug.WriteLine("pas d'erreur");
                this.errorMessage.IsVisible = false;
                Navigation.PushAsync(new TweetPage());
            }
        }

      
    }
}
