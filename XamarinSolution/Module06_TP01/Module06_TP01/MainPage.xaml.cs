using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module06_TP01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }

      
        public void seConnecterClicked(object sender, EventArgs e)
        {
            CacherErreur();
            if (string.IsNullOrEmpty(this.email.Text.ToString()) 
                || this.email.Text.Length < 3
                || string.IsNullOrEmpty(this.password.Text.ToString()) 
                || this.password.Text.Length < 6)
            {
                this.AfficherErreur("Veuillez saisir un email et un mot de passe valides");
                return;
            }
            else
            {
                AfficherContent();
                return;
            }

        }

        private void AfficherContent()
        {
            this.content.IsVisible = true;
        }

        private void AfficherErreur(string erreur)
        {
            this.errorMessage.Text = erreur;
            this.errorMessage.IsVisible = true;
        }

        private void CacherErreur()
        {
            this.errorMessage.IsVisible = false;
        }
    }
}
