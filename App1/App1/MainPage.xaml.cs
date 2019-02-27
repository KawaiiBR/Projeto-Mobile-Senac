using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryEmail.Text) ||
                string.IsNullOrEmpty(entrySenha.Text))
            {
                await DisplayAlert("Erro!", "Não deixe campos em branco", "OK");
            }
            else
            {
                if (entryEmail.Text == "admin" && entrySenha.Text == "admin")
                {
                    var page = new CadastrarEndereco();
                    await Navigation.PushModalAsync(page);
                }
                else
                {
                    await DisplayAlert("Erro!", "Senha ou email incorreto", "OK");
                }
            }
        }

        private void ButtonLogin_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonEsqueciSenha_Clicked(object sender, EventArgs e)
        {

        }
    }
}
