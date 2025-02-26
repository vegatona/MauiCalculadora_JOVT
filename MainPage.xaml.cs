namespace MauiCalculadora_JOVT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var peso = float.Parse(Peso.Text);
                var altura = float.Parse(Altura.Text);

                var imc = (peso / (altura * altura)*1000);


                IMC.Text = imc.ToString();

                //mensaje
                string resultado = "";
                if (imc < 18.5)
                {
                    resultado = "Tiene bajo peso";
                    Flaco.IsVisible = true;
                    Normal.IsVisible = false;
                    Gordo.IsVisible = false;
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tu peso es normal";
                    Flaco.IsVisible = false;
                    Normal.IsVisible = true;
                    Gordo.IsVisible = false;
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Tiene sobrepeso";
                    Flaco.IsVisible = false;
                    Normal.IsVisible = false;
                    Gordo.IsVisible = true;
                }
                else
                {
                    resultado = "Cuidate, porfavor";
                }
                DisplayAlert("Resultado: ", resultado, "Quitar");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favol, llena todo la informacion", "Quitar");
            }
        }

    }
}
