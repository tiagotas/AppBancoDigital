using AppBancoDigital.Service;
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

        private async void Button_Clicked_Entrar(object sender, EventArgs e)
        {
            try
            {
                Model.Cliente c = await DataServiceCliente.LoginAsync(new Model.Cliente
                {
                    Cpf = txt_cpf.Text,
                    Senha = txt_senha.Text,
                });

                if (c.Id != null)
                {
                    await Navigation.PushAsync(new View.TelaInicial());
                }
                else
                    throw new Exception("Dados de login inválidos.");

            } catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }           
        }
    }
}