using CarPartsChecklist.App.ViewModels;

namespace CarPartsChecklist.App.Views;

public partial class PgAll : ContentPage
{
	public PgAll(PgAllViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}