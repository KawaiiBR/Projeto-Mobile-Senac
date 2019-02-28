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
	public partial class NaoAceitamosCartao : ContentPage
	{
		public NaoAceitamosCartao ()
		{
			InitializeComponent ();
		}

        private void ButtonCorfirmar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Obrigado!", "Seu lanche já esta sendo feito, e será entregue o mais rápido possível", "OK");

            var page = new Menu();
            Navigation.PushModalAsync(page);
        }

        private void ButtonCancelar_Clicked(object sender, EventArgs e)
        {
            var page = new ConfirmacaoDePedido();
            Navigation.PushModalAsync(page);
        }
    }
}