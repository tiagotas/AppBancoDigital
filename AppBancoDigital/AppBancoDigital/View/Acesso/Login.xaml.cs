using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Acesso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked_Cadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Cliente.CadastroCliente());
        }

        private void Button_Clicked_Entrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.TelaInicial());
        }
    }
}