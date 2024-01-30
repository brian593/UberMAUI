using CloneUber.ViewModels;

namespace CloneUber.Views.Landing;

public partial class AccountPage : ContentPage
{
	public AccountPage(AccountPageVM viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}