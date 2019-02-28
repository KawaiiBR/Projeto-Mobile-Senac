using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Procurar_Endereco : ContentPage
	{
        public static string _cep { get; set; } = "";
        public static string _email { get; set; } = "";
        public static string _senha { get; set; } = "";

        private SQLiteAsyncConnection conexao;
        private ObservableCollection<Usuarios> usuarios;

        public Procurar_Endereco()
		{
			InitializeComponent ();
            if(_cep != "")
                CarregarEndereco();

            conexao = DependencyService.Get<ISQLite>().AcessarDB();
            conexao.CreateTableAsync<Usuarios>();
        }

        protected async override void OnAppearing()
        {
            var lista = await conexao.Table<Usuarios>().ToListAsync();
            usuarios = new ObservableCollection<Usuarios>(lista);

            base.OnAppearing();
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
                //Usuarios u = new Usuarios();
                //u.ID = new Guid();
                //u.Email = _email;
                //u.Senha = _senha;

                var u = new Usuarios
                {
                    ID = new Guid(),
                    Email = _email,
                    Senha = _senha,
                    NumeroDaCasa = Convert.ToInt32(entryNumero.Text),
                    Bairro = entryBairro.Text,
                    Rua = entryRua.Text,
                    Cidade = entryCidade.Text,
                    Estado = entryEstado.Text,
                    CEP = entryCEP.Text
                };

                conexao.InsertAsync(usuarios);
                usuarios.Add(u);
                DisplayAlert(null, "Gravado com sucesso!", "Ok");
                var page = new Menu();
                Navigation.PushModalAsync(page);
            }
        }
    }
}