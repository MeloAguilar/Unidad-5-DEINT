namespace HolaMundoMAUI;
using Entities;
public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnBotonClicado(object sender, EventArgs e)
	{

		if (String.IsNullOrEmpty(txtNombre.Text))
		{
			txtError.Text = "Debe escribir algo";
			txtError.IsVisible = true;
		}
		else
		{
			clsPersona persona = new clsPersona(txtNombre.Text, txtApellidos.Text);
			txtError.IsVisible = false;
			DisplayAlert("Saludo", $" Hola {persona.Nombre} {persona.Apellidos}", "Aceptar");
		}
	}

	private async void irAPaginaSliders(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync("");
	}
}

