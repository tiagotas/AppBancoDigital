using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();

            txt_correntista.Text = App.DadosCorrentista.Nome;
        }

        private void Button_Clicked_Fazer_Pix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.EnviarPix());
        }

        private void Button_Clicked_Receber_Pix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.ReceberPix());
        }
    }
}