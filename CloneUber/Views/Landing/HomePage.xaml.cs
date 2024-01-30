using CloneUber.ViewModels;

namespace CloneUber.Views.Landing;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageVM viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;

    }
}