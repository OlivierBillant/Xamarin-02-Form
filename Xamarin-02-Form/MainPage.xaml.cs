using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Xamarin_02_Form
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Connexion_Clicked(object sender, EventArgs e)
        {
            CheckEmpty();
            if (CheckEmpty())
            {
                CheckPassword();
            }
        }
        private void Retour_Clicked(object sender, EventArgs e)
        {
            if (!Preferences.Get("RememberMe", false))
            {
                ResetVisibility();
            }
        }

        public Boolean CheckEmpty()
        {
            if (identifiant.Text is null || password.Text is null)
            {
                DisplayAlert("Erreur", "Vous devez saisir une couple ID/PW", "Retour");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void CheckPassword()
        {
            String identifiantBase = "Olivier";
            String passwordBase = "motdepasse";
            if (identifiant.Text == identifiantBase && password.Text == passwordBase)
            {
                RememberMe();
                EditVisibility();
            }
            else
            {
                DisplayAlert("Erreur", "Identifiant ou mot de passe invalide", "Retour");
            }
        }

        public void EditVisibility()
        {
            connexion.IsVisible = false;
            fil.IsVisible = true;
        }

        public void ResetVisibility()
        {
            connexion.IsVisible = true;
            fil.IsVisible = false;
        }

        public void RememberMe()
        {
            if (rememberme.IsToggled)
            {
                Preferences.Set("RememberMe", true);
            }
            else
            {
                Preferences.Set("RememberMe", false);
            }
        }

    }
}
