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
        }

        private void Button_Clicked_Cadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Correntista.Cadastro());
        }

        private async void Button_Clicked_Entrar(object sender, EventArgs e)
        {
            try
            {
                Model.Correntista c = await DataServiceCorrentista.LoginAsync(new Model.Correntista
                {
                    Cpf = txt_cpf.Text,
                    Senha = txt_senha.Text,
                });

                if (c.Id != null)
                {
                    App.DadosCorrentista = c;
                    App.Current.MainPage = new NavigationPage(new View.TelaInicial());
                    //App.Current.MainPage = new View.TelaInicial();
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