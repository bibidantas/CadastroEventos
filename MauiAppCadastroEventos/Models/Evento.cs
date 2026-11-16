namespace CadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; } = string.Empty;
        public double CustoPorParticipante { get; set; }

        // Propriedades calculadas (exibidas na tela de confirmação)
        public int DuracaoDias => (DataTermino.Date - DataInicio.Date).Days + 1;
        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
