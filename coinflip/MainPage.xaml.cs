namespace coinflip
{
    public partial class MainPage : ContentPage
    {
        Random aleatorio = new Random();
        int c = 0;
        string lado = null;

        public MainPage()
        {
            InitializeComponent();
        }

        private void JogarMoedaButton_Clicked(object sender, EventArgs e)
        {
            int moeda = aleatorio.Next(2);

            if (MoedaLadoPicker.SelectedIndex != -1)
            {
                if (moeda == 0)
                    lado = "CARA";
                else if (moeda == 1)
                    lado = "COROA";

                if (moeda == MoedaLadoPicker.SelectedIndex)
                {
                    c++;
                    ResultadoLabel.Text = $"Você acertou, o lado da Moeda é {lado}.";
                }
                else
                {
                    c--;
                    ResultadoLabel.Text = $"Você não acertou, o lado da Moeda é {lado}.";
                }
                
                PontuacaoLabel.Text = $"A sua Pontuação é: {c}";
            }
            else
                ResultadoLabel.Text = "Escolha um lado da moeda";

        }

    }
}
