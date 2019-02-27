using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Procurar_Endereco : ContentPage
	{
        public static string _cep { get; set; } = "";

        public Procurar_Endereco()
		{
			InitializeComponent ();
            if(_cep != "")
                CarregarEndereco();
        }

        public async void CarregarEndereco()
        {

            BuscaCEP resultado = new BuscaCEP();
            var r = await resultado.Buscar(_cep);

            entryBairro.Text = r.bairro;
            entryRua.Text = r.logradouro;
            entryCidade.Text = r.localidade;
            entryEstado.Text = r.uf;
            entryCEP.Text = r.cep;

        }

        private void ButtonCorfirmar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryNumero.Text) ||
                string.IsNullOrEmpty(entryBairro.Text) ||
                string.IsNullOrEmpty(entryRua.Text) ||
                string.IsNullOrEmpty(entryCidade.Text) ||
                string.IsNullOrEmpty(entryEstado.Text))
            {
                DisplayAlert("Espaço vazio", "Não se esqueça de preencher os campos obrigatórios", "OK");
            }
            else if (Convert.ToInt32(entryNumero.Text) <= 0)
            {
                DisplayAlert("Nº incorreto", "Numero da casa incorreto, digite um numero valido", "OK");
            }
            else
            {
                var page = new Menu();
                Navigation.PushModalAsync(page);
            }
        }
    }
}