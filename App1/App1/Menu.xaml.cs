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
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
            Detail = new NavigationPage(new EscolherTipoLanhe());
		}

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new MainPage();
            Navigation.PushModalAsync(page);
        }

        private void ViewCell_Tapped_1(object sender, EventArgs e)
        {
            var page = new CadastrarEndereco();
            Navigation.PushModalAsync(page);
        }
    }
}