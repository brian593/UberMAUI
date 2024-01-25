using CloneUber.ViewModels;

namespace CloneUber.Views.Register;

public partial class CreateAccountPage : ContentPage
{
	public CreateAccountPage(CreateAccountPageVM viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
