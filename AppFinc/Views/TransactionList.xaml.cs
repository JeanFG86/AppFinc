using AppFinc.ViewModels;

namespace AppFinc.Views;

public partial class TransactionList : ContentPage
{
	public TransactionList()
	{
		BindingContext = new TransactionListViewModel();
        InitializeComponent();
	}
}