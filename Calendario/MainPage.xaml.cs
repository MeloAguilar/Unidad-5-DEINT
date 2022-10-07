namespace Calendario
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}



		 void EntradaIntroducida(object sender, DateChangedEventArgs e)
		{
			

			if(dpFechaEntrada.Date >= dpFechaSalida.Date)
			{
				lblError.IsVisible = false;
				dpFechaSalida.Date = dpFechaEntrada.Date.AddDays(1);
			}
			if (dpFechaEntrada.Date < DateTime.Now.Date)
			{
				lblError.IsVisible=true;
				dpFechaEntrada.Date = DateTime.Now.Date;
			}
			else
			{
				lblError.IsVisible=false;
			}

		}
	}
}