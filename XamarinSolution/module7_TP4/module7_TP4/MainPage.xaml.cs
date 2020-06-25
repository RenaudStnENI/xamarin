using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using module7_TP04.Entities;
using module7_TP04.Services;

namespace module7_TP04
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
            this.btnConnexion.Clicked += BtnConnexion_Clicked;
            this.errorLabel.IsVisible = false;
            this.tweetList.IsVisible = false;
            this.twitterService = new TwitterServiceImpl();
        }

        private void BtnConnexion_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("btn clicked");
            String login = this.identifiant.Text;
            String password = this.motDePasse.Text;
            Boolean isRemind = this.memorise.IsToggled;

            String errors = this.twitterService.Authenticate(new User() { Login = login, Password = password});

            if (!String.IsNullOrEmpty(errors))
            {
                this.errorLabel.Text = errors;
                this.errorLabel.IsVisible = true;
            }
            else
            {
                this.errorLabel.Text = "";
                this.errorLabel.IsVisible = false;
                this.connectionForm.IsVisible = false;
                this.tweetList.IsVisible = true;
            }
        }
    }
}
