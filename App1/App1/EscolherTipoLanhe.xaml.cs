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
	public partial class EscolherTipoLanhe : ContentPage
	{
		public EscolherTipoLanhe ()
		{
			InitializeComponent ();
		}

        private void ButtonCQ_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ButtonCQ_Clicked_1(object sender, EventArgs e)
        {
            var page = new Cachorro_Quentes();
            Navigation.PushModalAsync(page);
        }
    }
}