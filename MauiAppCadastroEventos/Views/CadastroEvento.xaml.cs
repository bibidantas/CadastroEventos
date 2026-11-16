using System.Globalization;
using CadastroEventos.Models;

namespace CadastroEventos.Views
{
    public partial class CadastroEvento : ContentPage
    {
        public CadastroEvento()
        {
            InitializeComponent();

            DateTime hoje = DateTime.Today;

            dtpck_inicio.MinimumDate = hoje;
            dtpck_inicio.MaximumDate = hoje.AddYears(5);
            dtpck_inicio.Date = hoje;

            dtpck_termino.MinimumDate = hoje;
            dtpck_termino.MaximumDate = hoje.AddYears(5);
            dtpck_termino.Date = hoje;
        }

        // Quando a data de início muda, o término não pode ser anterior a ela
        private void dtpck_inicio_DateSelected(object? sender, DateChangedEventArgs e)
        {
            dtpck_termino.MinimumDate = e.NewDate;

            if (dtpck_termino.Date < e.NewDate)
                dtpck_termino.Date = e.NewDate;
        }

        private async void Button_Clicked(object? sender, EventArgs e)
        {
            try
            {
                // Validações
                if (string.IsNullOrWhiteSpace(ent_nome.Text))
                {
                    await DisplayAlert("Atenção", "Informe o nome do evento.", "OK");
                    return;
                }

                if (!int.TryParse(ent_participantes.Text, out int participantes) || participantes <= 0)
                {
                    await DisplayAlert("Atenção", "Informe um número de participantes válido (maior que zero).", "OK");
                    return;
                }

                if (string.IsNullOrWhiteSpace(ent_local.Text))
                {
                    await DisplayAlert("Atenção", "Informe o local do evento.", "OK");
                    return;
                }

                // Aceita "49,90" (pt-BR) ou "49.90"
                string textoCusto = ent_custo.Text?.Trim() ?? "";
                bool custoOk =
                    double.TryParse(textoCusto, NumberStyles.Any, CultureInfo.CurrentCulture, out double custo) ||
                    double.TryParse(textoCusto, NumberStyles.Any, CultureInfo.InvariantCulture, out custo);

                if (!custoOk || custo < 0)
                {
                    await DisplayAlert("Atenção", "Informe um custo por participante válido.", "OK");
                    return;
                }

                // Monta o objeto que será mostrado na próxima tela
                Evento evento = new()
                {
                    Nome = ent_nome.Text.Trim(),
                    DataInicio = dtpck_inicio.Date,
                    DataTermino = dtpck_termino.Date,
                    NumeroParticipantes = participantes,
                    Local = ent_local.Text.Trim(),
                    CustoPorParticipante = custo
                };

                // BindingContext: a tela de confirmação passa a "enxergar" o objeto evento
                await Navigation.PushAsync(new ConfirmacaoEvento
                {
                    BindingContext = evento
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
