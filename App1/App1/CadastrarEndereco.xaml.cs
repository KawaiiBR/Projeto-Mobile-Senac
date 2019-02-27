using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App1;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastrarEndereco : ContentPage
	{
		public CadastrarEndereco ()
		{
			InitializeComponent ();
		}       

        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryCEP.Text))
            {
                DisplayAlert("Erro!", "Não deixe campos em branco, se não sabe seu CEP pode preencher todo seu cadastro manuamente clicando no botão 'Não sei meu CEP'", "OK");
            }
            else
            {
                Procurar_Endereco._cep = entryCEP.Text;
                var page = new Procurar_Endereco();
                Navigation.PushModalAsync(page);
            }
        }

        private void NaoSeiCEP_Clicked(object sender, EventArgs e)
        {
            Procurar_Endereco._cep = "";
            var page = new Procurar_Endereco();
            Navigation.PushModalAsync(page);
        }
    }
}