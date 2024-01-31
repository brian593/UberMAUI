using CloneUber.ViewModels;

namespace CloneUber.Views.Landing;

public partial class ActivityPage : ContentPage
{
	public ActivityPage(ActivityPageVM viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;

    }
}