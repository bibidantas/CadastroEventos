namespace CadastroEventos.Views
{
    public partial class BoasVindas : ContentPage
    {
        public BoasVindas()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroEvento());
        }
    }
}
