using AppBancoDigital.Service;
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

        private async void Button_Clicked_Cadastrar(object sender, EventArgs e)
        {
            try
            {
                Model.Cliente c = await DataServiceCliente.SaveAsync(new Model.Cliente
                {
                    Nome = txt_nome.Text,
                    Email = txt_email.Text,
                    Data_Nascimento = dtpck_data_nascimento.Date,
                    Cpf = txt_cpf.Text,
                    Senha = txt_senha.Text,
                }) ;

                if (c.Id != null)
                {
                    await Navigation.PushAsync(new View.TelaInicial());
                }
                else
                    throw new Exception("Ocorreu um erro ao salvar seu cadastro.");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private void Button_Clicked_Login(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}