using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_02_Form
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CheckEmpty();
            if (CheckEmpty())
            {
                CheckPassword();
            }
        }

        public Boolean CheckEmpty()
        {
            if (identifiant.Text is null || password.Text is null)
            {
                DisplayAlert("Error", "Vous devez saisir une couple ID/PW", "cancel");
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
                EditVisibility();
            }
            else
            {
                DisplayAlert("Error", "Identifiant ou mot de passe invalide", "cancel");
                ;
            }
        }

        public void EditVisibility()
        {
            connexion.IsVisible = false;
            fil.IsVisible = true;
        }
    }
}
