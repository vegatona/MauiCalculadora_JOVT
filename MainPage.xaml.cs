namespace MauiCalculadora_JOVT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            var altura = double.Parse(Altura.Text);
            var peso = double.Parse(Peso.Text);
            var imc = peso / (altura * altura);

            var Resultado = imc;

            IMC.Text = Resultado.ToString();
        }
    }

}
