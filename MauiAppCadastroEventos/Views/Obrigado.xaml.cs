namespace CadastroEventos.Views
{
    public partial class Obrigado : ContentPage
    {
        public Obrigado()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object? sender, EventArgs e)
        {
            // Volta direto à tela inicial, descartando as telas intermediárias
            await Navigation.PopToRootAsync();
        }
    }
}
