using AppFinc.Views;

namespace AppFinc;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TransactionList();
	}
}
