using CloneUber.ViewModels;

namespace CloneUber.Views.Landing;

public partial class ServicesPage : ContentPage
{
	public ServicesPage(ServicesPageVM viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;

    }
}