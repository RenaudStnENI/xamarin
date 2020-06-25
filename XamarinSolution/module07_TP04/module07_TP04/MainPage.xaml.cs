using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using module07_TP04.Entities;
using module07_TP04.Services;
using System.Diagnostics;

namespace module07_TP04
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService;

        public MainPage()
        {
            InitializeComponent();
            this.btnConnect.Clicked += BtnConnectClicked;
            this.errorMessage.IsVisible = false;
            this.liste.IsVisible = false;
            this.connectionForm.IsVisible = true;
            this.twitterService = new TwitterServiceImpl();
        }

        private void BtnConnectClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("click");

            String email = this.email.Text;
            String password = this.mdp.Text;
            Boolean isRemind = this.memorise.IsToggled;

            String erreurs = this.twitterService.Authenticate(new User() { Email = email, Password = password });

            if (!String.IsNullOrEmpty(erreurs))
            {
                this.errorMessage.Text = erreurs;
                this.errorMessage.IsVisible = true;
            }
            else
            {
                this.errorMessage.IsVisible = false;
                this.connectionForm.IsVisible = false;
                this.liste.IsVisible = true;
            }
        }
    }
}
