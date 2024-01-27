using CloneUber.ViewModels;

namespace CloneUber.Views.Register;

public partial class CompleteRegistrationPage : ContentPage
{
	public CompleteRegistrationPage(CompleteRegistrationPageVM viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
