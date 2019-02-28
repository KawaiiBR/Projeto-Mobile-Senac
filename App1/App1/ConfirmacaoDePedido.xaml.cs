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
	public partial class ConfirmacaoDePedido : ContentPage
	{
		public ConfirmacaoDePedido()
		{
			InitializeComponent();
		}

        private void ButtonConfirmar_Clicked(object sender, EventArgs e)
        {
            var page = new NaoAceitamosCartao();
            Navigation.PushModalAsync(page);
        }
    }
}