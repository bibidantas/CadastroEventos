namespace CadastroEventos.Views
{
    public partial class ConfirmacaoEvento : ContentPage
    {
        public ConfirmacaoEvento()
        {
            InitializeComponent();
        }

        private async void btn_confirmar_Clicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new Obrigado());
        }

        private async void btn_corrigir_Clicked(object? sender, EventArgs e)
        {
            // Volta para a tela de cadastro
            await Navigation.PopAsync();
        }
    }
}
