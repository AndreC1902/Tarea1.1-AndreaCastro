using Tarea1._1_AndreaCastro.ViewsN;

namespace Tarea1._1_AndreaCastro
{
    public partial class MainPage : ContentPage
    {
        private Operaciones operaciones;

        public MainPage()
        {
            InitializeComponent();
            operaciones = new Operaciones();
        }

        private async void btnCalcularSuma(object sender, System.EventArgs e)
        {
            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);
            double resultado = operaciones.Sumar(num1, num2);

            await Navigation.PushAsync(new PageResult(resultado));
        }

        private async void btnCalcularResta(object sender, System.EventArgs e)
        {
            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);
            double resultado = operaciones.Restar(num1, num2);

            await Navigation.PushAsync(new PageResult(resultado));
        }

        private async void btnCalcularDivision(object sender, System.EventArgs e)
        {
            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);
            double resultado = operaciones.Dividir(num1, num2);

            await Navigation.PushAsync(new PageResult(resultado));
        }

        private async void btnCalcularMultiplicacion(object sender, System.EventArgs e)
        {
            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);
            double resultado = operaciones.Multiplicar(num1, num2);

            await Navigation.PushAsync(new PageResult(resultado));
        }
    }
}