using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Cliente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Cadastrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.TelaInicial());
        }

        private void Button_Clicked_Login(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}