using CloneUber.ViewModels;

namespace CloneUber.Views.Register;

public partial class StartPage : ContentPage
{
	public StartPage(StartPageVM viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
