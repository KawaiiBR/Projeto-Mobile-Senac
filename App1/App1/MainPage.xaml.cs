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
                    Procurar_Endereco._email = entryEmail.Text;
                    Procurar_Endereco._senha = entrySenha.Text;
                    var page = new CadastrarEndereco();
                    await Navigation.PushModalAsync(page);
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
