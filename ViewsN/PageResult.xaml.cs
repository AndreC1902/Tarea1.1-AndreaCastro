namespace Tarea1._1_AndreaCastro.ViewsN;

public partial class PageResult : ContentPage
{
	public PageResult(double resultado)
	{
		InitializeComponent();
        resultadoLabel.Text = resultado.ToString();
    }
}